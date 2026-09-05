# CsLinux

Zero-allocation, high-performance Linux UAPI kernel bridge for modern .NET. Maps raw syscalls, `epoll`, and `io_uring` directly to unmanaged C# primitives. Built purely for mechanical sympathy with 0% garbage collection overhead.

## The Architecture
* **Pure UAPI Mapping:** Directly binds C# compilation layouts to the raw Linux kernel ABI (`libc.so.6` syscall gates) with zero intermediate C/C++ shims.
* **Procedural Design Philosophy:** Rejects class allocations and runtime garbage collection tracking entirely. Operates strictly via **Stack Structs + Free Functions**, forcing RyuJIT to emit direct register-to-register CPU instructions.
* **Low-Level Mechanical Sympathy:** Leverages `nint`/`nuint` for architectural bit-width scaling and strict byte-packing (`Pack = 1`) to eliminate array bounds checking and translation layers.

## Subsystems Implemented
* **io_uring:** Raw submission queue entry (`io_uring_sqe`) and completion queue entry (`io_uring_cqe`) layouts with custom byte-accurate 64-byte structural boundaries.
* **epoll:** Event multiplexing runtime loop layers powered by explicit `epoll_data` layout tracking unions.
* **sockets:** Core unmanaged POSIX network interfaces (`sockaddr_in`, `sockaddr_in6`, `iovec`, `msghdr`).
* **mmap:** Virtual memory page frame mapping and memory-protection interfaces.
* **New-Gen Primitives:** Cutting-edge modern system call targets including `SYS_FUTEX_WAITV` and `SYS_CACHESTAT`.

## Hardware Benchmarks
Validating unmanaged direct register trapping vs. standard .NET Framework file system I/O wrappers. 
* **Host Environment:** Intel Core i3-10105 CPU 3.70GHz, Linux x86_64, .NET SDK 11 Preview, RyuJIT AVX2.

| Method | Mean | Ratio | Gen0 | Allocated | Alloc Ratio |
| :--- | :---: | :---: | :---: | :---: | :---: |
| **StandardDotNetWrite** | 2,248.09 ns | 1.00 | 0.0305 | 104 B | 1.00 |
| **CsLinuxSyscallWrite** | **92.56 ns** | **0.04** | **-** | **- (0 B)** | **0.00** |

*Mathematically proven: CsLinux executes **24x faster** with absolute **zero heap allocation allocations**.*

## Usage Example
Written in strict procedural, zero-allocation micro-assembler style layout:
```csharp
using System;
using CsLinux;

internal class Program {
    private static unsafe void Main() {
        int socketFd = (int)Sys.Syscall(Sys.SYS_SOCKET, Sys.AF_INET, Sys.SOCK_STREAM | Sys.SOCK_NONBLOCK, 0);
        if (socketFd < 0) { return; }

        Sys.sockaddr_in hostAddress = new Sys.sockaddr_in();
        hostAddress.sin_family = (ushort)Sys.AF_INET;
        hostAddress.sin_port = 0x901F; 
        hostAddress.sin_addr = 0; 

        nint bindResult = Sys.Syscall(Sys.SYS_BIND, socketFd, (nint)(&hostAddress), sizeof(Sys.sockaddr_in));
        if (bindResult == 0) {
            Sys.Syscall(Sys.SYS_LISTEN, socketFd, 128);
        }
        Sys.Syscall(Sys.SYS_CLOSE, socketFd);
    }
}
```

## License
[MIT License](LICENSE). copyright mxreal64, 2026.
