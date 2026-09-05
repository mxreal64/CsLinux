# CsLinux

High-performance Linux UAPI kernel bridge for modern .NET. Maps raw syscalls, `epoll`, and `io_uring` directly to unmanaged C# primitives.

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

(on an i3-10105 w/ 8gb of ram)
```bash
// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2026-09-05 18:43 (0h 0m from now) **
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts/results/IoBenchmark-report.csv
  BenchmarkDotNet.Artifacts/results/IoBenchmark-report-github.md
  BenchmarkDotNet.Artifacts/results/IoBenchmark-report.html

// * Detailed results *
IoBenchmark.StandardDotNetWrite: DefaultJob
Runtime = .NET 11.0.0 (11.0.26.38203), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 2.248 us, StdErr = 0.001 us (0.05%), N = 13, StdDev = 0.004 us
Min = 2.237 us, Q1 = 2.248 us, Median = 2.249 us, Q3 = 2.251 us, Max = 2.252 us
IQR = 0.003 us, LowerFence = 2.243 us, UpperFence = 2.256 us
ConfidenceInterval = [2.243 us; 2.253 us] (CI 99.9%), Margin = 0.005 us (0.22% of Mean)
Skewness = -1.36, Kurtosis = 3.93, MValue = 2
-------------------- Histogram --------------------
[2.235 us ; 2.254 us) | @@@@@@@@@@@@@
---------------------------------------------------

IoBenchmark.CsLinuxSyscallWrite: DefaultJob
Runtime = .NET 11.0.0 (11.0.26.38203), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 92.561 ns, StdErr = 0.053 ns (0.06%), N = 15, StdDev = 0.205 ns
Min = 92.311 ns, Q1 = 92.373 ns, Median = 92.554 ns, Q3 = 92.668 ns, Max = 92.967 ns
IQR = 0.295 ns, LowerFence = 91.930 ns, UpperFence = 93.110 ns
ConfidenceInterval = [92.341 ns; 92.780 ns] (CI 99.9%), Margin = 0.220 ns (0.24% of Mean)
Skewness = 0.49, Kurtosis = 2, MValue = 2
-------------------- Histogram --------------------
[92.201 ns ; 93.077 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.14.0, PrimeLinux
Intel Core i3-10105 CPU 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 11.0.100-preview.7.26381.103
  [Host]     : .NET 11.0.0 (11.0.26.38203), X64 RyuJIT AVX2
  DefaultJob : .NET 11.0.0 (11.0.26.38203), X64 RyuJIT AVX2


| Method              | Mean        | Error    | StdDev   | Ratio | Gen0   | Allocated | Alloc Ratio |
|-------------------- |------------:|---------:|---------:|------:|-------:|----------:|------------:|
| StandardDotNetWrite | 2,248.09 ns | 4.926 ns | 4.113 ns |  1.00 | 0.0305 |     104 B |        1.00 |
| CsLinuxSyscallWrite |    92.56 ns | 0.220 ns | 0.205 ns |  0.04 |      - |         - |        0.00 |

// * Hints *
Outliers
  IoBenchmark.StandardDotNetWrite: Default -> 2 outliers were removed, 4 outliers were detected (2.24 us, 2.24 us, 2.30 us, 2.31 us)

// * Legends *
  Mean        : Arithmetic mean of all measurements
  Error       : Half of 99.9% confidence interval
  StdDev      : Standard deviation of all measurements
  Ratio       : Mean of the ratio distribution ([Current]/[Baseline])
  Gen0        : GC Generation 0 collects per 1000 operations
  Allocated   : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  Alloc Ratio : Allocated memory ratio distribution ([Current]/[Baseline])
  1 ns        : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:00:37 (37.07 sec), executed benchmarks: 2

Global total time: 00:00:40 (40.6 sec), executed benchmarks: 2
// * Artifacts cleanup *
Artifacts cleanup is finished
[bash]$
```
yes.

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
