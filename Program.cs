using System;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CsLinux;

internal class Program {
    private static unsafe void Main() {
        BenchmarkRunner.Run<IoBenchmark>();
    }
}

[MemoryDiagnoser]
public class IoBenchmark {
    private byte[] _managedBuf = null!;
    private nint _unmanagedBuf;
    private int _nullFd;

    [GlobalSetup]
    public unsafe void Setup() {
        _managedBuf = System.Text.Encoding.UTF8.GetBytes("TuxInterop Performance Validation Testing Data Payload String\n");
        _unmanagedBuf = (nint)NativeMemory.Alloc((nuint)_managedBuf.Length);
        Marshal.Copy(_managedBuf, 0, _unmanagedBuf, _managedBuf.Length);
        _nullFd = (int)Sys.Syscall(Sys.SYS_OPEN, (nint)"/dev/null"u8.GetPinnableReference(), 1, 0);
    }

    [GlobalCleanup]
    public unsafe void Cleanup() {
        Sys.Syscall(Sys.SYS_CLOSE, _nullFd);
        NativeMemory.Free((void*)_unmanagedBuf);
    }

    [Benchmark(Baseline = true)]
    public void StandardDotNetWrite() {
        // Standard framework overhead: allocates strings and formats data buffers
        string msg = "TuxInterop Performance Validation Testing Data Payload String\n";
        System.IO.File.WriteAllText("/dev/null", msg);
    }

    [Benchmark]
    public unsafe void CsLinuxSyscallWrite() {
        // Your procedural system: direct hardware register trapping
        Sys.Syscall(Sys.SYS_WRITE, _nullFd, (byte*)_unmanagedBuf, (nuint)_managedBuf.Length);
    }
}
