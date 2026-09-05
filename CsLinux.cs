namespace CsLinux;

public static unsafe partial class Sys {

    public const nint SYS_READ          = 0;
    public const nint SYS_WRITE         = 1;
    public const nint SYS_OPEN          = 2;
    public const nint SYS_CLOSE         = 3;
    public const nint SYS_STAT          = 4;
    public const nint SYS_FSTAT         = 5;
    public const nint SYS_LSTAT         = 6;
    public const nint SYS_POLL          = 7;
    public const nint SYS_LSEEK         = 8;
    public const nint SYS_MMAP          = 9;
    public const nint SYS_MPROTECT      = 10;
    public const nint SYS_MUNMAP        = 11;
    public const nint SYS_BRK           = 12;
    public const nint SYS_RT_SIGACTION  = 13;
    public const nint SYS_RT_SIGPROCMASK = 14;
    public const nint SYS_RT_SIGRETURN  = 15;
    public const nint SYS_IOCTL         = 16;
    public const nint SYS_PREAD64       = 17;
    public const nint SYS_PWRITE64      = 18;
    public const nint SYS_READV         = 19;
    public const nint SYS_WRITEV        = 20;
    public const nint SYS_ACCESS        = 21;
    public const nint SYS_PIPE          = 22;
    public const nint SYS_SELECT        = 23;
    public const nint SYS_SCHED_YIELD   = 24;
    public const nint SYS_MREMAP        = 25;
    public const nint SYS_MSYNC         = 26;
    public const nint SYS_MINCORE       = 27;
    public const nint SYS_MADVISE       = 28;
    public const nint SYS_SHMGET        = 29;
    public const nint SYS_SHMAT         = 30;
    public const nint SYS_SHMCTL        = 31;
    public const nint SYS_DUP           = 32;
    public const nint SYS_DUP2          = 33;
    public const nint SYS_PAUSE         = 34;
    public const nint SYS_NANOSLEEP     = 35;
    public const nint SYS_GETITIMER     = 36;
    public const nint SYS_ALARM         = 37;
    public const nint SYS_SETITIMER     = 38;
    public const nint SYS_GETPID        = 39;
    public const nint SYS_SENDFILE      = 40;
    public const nint SYS_SOCKET        = 41;
    public const nint SYS_CONNECT       = 42;
    public const nint SYS_ACCEPT        = 43;
    public const nint SYS_SENDTO        = 44;
    public const nint SYS_RECVFROM      = 45;
    public const nint SYS_SENDMSG       = 46;
    public const nint SYS_RECVMSG       = 47;
    public const nint SYS_SHUTDOWN      = 48;
    public const nint SYS_BIND          = 49;
    public const nint SYS_LISTEN        = 50;
    public const nint SYS_GETSOCKNAME   = 51;
    public const nint SYS_GETPEERNAME   = 52;
    public const nint SYS_SOCKETPAIR    = 53;
    public const nint SYS_SETSOCKOPT    = 54;
    public const nint SYS_GETSOCKOPT    = 55;
    public const nint SYS_CLONE         = 56;
    public const nint SYS_FORK          = 57;
    public const nint SYS_VFORK         = 58;
    public const nint SYS_EXECVE        = 59;
    public const nint SYS_EXIT          = 60;
    public const nint SYS_WAIT4         = 61;
    public const nint SYS_KILL          = 62;
    public const nint SYS_UNAME         = 63;
    public const nint SYS_SEMGET        = 64;
    public const nint SYS_SEMOP         = 65;
    public const nint SYS_SEMCTL        = 66;
    public const nint SYS_SHMDT         = 67;
    public const nint SYS_MSGGET        = 68;
    public const nint SYS_MSGSND        = 69;
    public const nint SYS_MSGRCV        = 70;
    public const nint SYS_MSGCTL        = 71;
    public const nint SYS_FCNTL         = 72;
    public const nint SYS_FLOCK         = 73;
    public const nint SYS_FSYNC         = 74;
    public const nint SYS_FDATASYNC     = 75;
    public const nint SYS_TRUNCATE      = 76;
    public const nint SYS_FTRUNCATE     = 77;
    public const nint SYS_GETDENTS      = 78;
    public const nint SYS_GETCWD        = 79;
    public const nint SYS_CHDIR         = 80;
    public const nint SYS_FCHDIR        = 81;
    public const nint SYS_RENAME        = 82;
    public const nint SYS_MKDIR         = 83;
    public const nint SYS_RMDIR         = 84;
    public const nint SYS_CREAT         = 85;
    public const nint SYS_LINK          = 86;
    public const nint SYS_UNLINK        = 87;
    public const nint SYS_SYMLINK       = 88;
    public const nint SYS_READLINK      = 89;
    public const nint SYS_CHMOD         = 90;
    public const nint SYS_FCHMOD        = 91;
    public const nint SYS_CHOWN         = 92;
    public const nint SYS_FCHOWN        = 93;
    public const nint SYS_LCHOWN        = 94;
    public const nint SYS_UMASK         = 95;
    public const nint SYS_GETTIMEOFDAY  = 96;
    public const nint SYS_GETRLIMIT     = 97;
    public const nint SYS_GETRUSAGE     = 98;
    public const nint SYS_SYSINFO       = 99;
    public const nint SYS_TIMES         = 100;
    public const nint SYS_PTRACE        = 101;
    public const nint SYS_GETUID        = 102;
    public const nint SYS_SYSLOG        = 103;
    public const nint SYS_GETGID        = 104;
    public const nint SYS_SETUID        = 105;
    public const nint SYS_SETGID        = 106;
    public const nint SYS_GETEUID       = 107;
    public const nint SYS_GETEGID       = 108;
    public const nint SYS_SETPGID       = 109;
    public const nint SYS_GETPPID       = 110;
    public const nint SYS_GETPGRP       = 111;
    public const nint SYS_SETSID        = 112;
    public const nint SYS_SETREUID      = 113;
    public const nint SYS_SETREGID      = 114;
    public const nint SYS_GETGROUPS     = 115;
    public const nint SYS_SETGROUPS     = 116;
    public const nint SYS_SETRESUID     = 117;
    public const nint SYS_GETRESUID     = 118;
    public const nint SYS_SETRESGID     = 119;
    public const nint SYS_GETRESGID     = 120;
    public const nint SYS_GETPGID       = 121;
    public const nint SYS_SETFSUID      = 122;
    public const nint SYS_SETFSGID      = 123;
    public const nint SYS_GETSID        = 124;
    public const nint SYS_CAPGET        = 125;
    public const nint SYS_CAPSET        = 126;
    public const nint SYS_RT_SIGPENDING = 127;
    public const nint SYS_RT_SIGTIMEDWAIT = 128;
    public const nint SYS_RT_SIGQUEUEINFO = 129;
    public const nint SYS_RT_SIGSUSPEND = 130;
    public const nint SYS_SIGALTSTACK   = 131;
    public const nint SYS_UTIME         = 132;
    public const nint SYS_MKNOD         = 133;
    public const nint SYS_USELIB        = 134;
    public const nint SYS_PERSONALITY   = 135;
    public const nint SYS_USTAT         = 136;
    public const nint SYS_STATFS        = 137;
    public const nint SYS_FSTATFS       = 138;
    public const nint SYS_SYSFS         = 139;
    public const nint SYS_GETPRIORITY   = 140;
    public const nint SYS_SETPRIORITY   = 141;
    public const nint SYS_SCHED_SETPARAM = 142;
    public const nint SYS_SCHED_GETPARAM = 143;
    public const nint SYS_SCHED_SETSCHEDULER = 144;
    public const nint SYS_SCHED_GETSCHEDULER = 145;
    public const nint SYS_SCHED_GET_PRIORITY_MAX = 146;
    public const nint SYS_SCHED_GET_PRIORITY_MIN = 147;
    public const nint SYS_SCHED_RR_GET_INTERVAL = 148;
    public const nint SYS_MLOCK         = 149;
    public const nint SYS_MUNLOCK       = 150;
    public const nint SYS_MLOCKALL      = 151;
    public const nint SYS_MUNLOCKALL    = 152;
    public const nint SYS_VHANGUP       = 153;
    public const nint SYS_MODIFY_LDT    = 154;
    public const nint SYS_CHROOT        = 155;
    public const nint SYS_PIVOT_ROOT    = 157;
    public const nint SYS_SYSCTL        = 158;
    public const nint SYS_PRCTL         = 159;
    public const nint SYS_ARCH_PRCTL    = 160;
    public const nint SYS_ADJTIMEX      = 161;
    public const nint SYS_SETRLIMIT     = 162;
    public const nint SYS_CHROOT_2      = 163;
    public const nint SYS_SETTIMEOFDAY  = 164;
    public const nint SYS_MOUNT         = 165;
    public const nint SYS_UMOUNT2       = 166;
    public const nint SYS_SWAPON        = 167;
    public const nint SYS_SWAPOFF       = 168;
    public const nint SYS_REBOOT        = 169;
    public const nint SYS_SETHOSTNAME   = 170;
    public const nint SYS_SETDOMAINNAME = 171;
    public const nint SYS_IOPL          = 172;
    public const nint SYS_IOPERM        = 173;
    public const nint SYS_CREATE_MODULE = 174;
    public const nint SYS_INIT_MODULE   = 175;
    public const nint SYS_DELETE_MODULE = 176;
    public const nint SYS_GET_KERNEL_SYMS = 177;
    public const nint SYS_QUERY_MODULE  = 178;
    public const nint SYS_QUOTACTL      = 179;
    public const nint SYS_NFSSERVCTL    = 180;
    public const nint SYS_GETPMSG       = 181;
    public const nint SYS_PUTPMSG       = 182;
    public const nint SYS_AFS_SYSCALL   = 183;
    public const nint SYS_TUXCALL       = 184;
    public const nint SYS_SECURITY      = 185;
    public const nint SYS_GETTID        = 186;
    public const nint SYS_READAHEAD     = 187;
    public const nint SYS_SETXATTR      = 188;
    public const nint SYS_LSETXATTR     = 189;
    public const nint SYS_FSETXATTR     = 190;
    public const nint SYS_GETXATTR      = 191;
    public const nint SYS_LGETXATTR     = 192;
    public const nint SYS_FGETXATTR     = 193;
    public const nint SYS_LISTXATTR     = 194;
    public const nint SYS_LLISTXATTR    = 195;
    public const nint SYS_FLISTXATTR    = 196;
    public const nint SYS_REMOVEXATTR   = 197;
    public const nint SYS_LREMOVEXATTR  = 198;
    public const nint SYS_FREMOVEXATTR  = 199;
    public const nint SYS_TKILL         = 200;
    public const nint SYS_TIME          = 201;
    public const nint SYS_FUTEX         = 202;
    public const nint SYS_SCHED_SETAFFINITY = 203;
    public const nint SYS_SCHED_GETAFFINITY = 204;
    public const nint SYS_SET_THREAD_AREA = 205;
    public const nint SYS_IO_SETUP      = 206;
    public const nint SYS_IO_DESTROY    = 207;
    public const nint SYS_IO_GETEVENTS  = 208;
    public const nint SYS_IO_SUBMIT     = 209;
    public const nint SYS_IO_CANCEL     = 210;
    public const nint SYS_GET_THREAD_AREA = 211;
    public const nint SYS_LOOKUP_COOKIE = 212;
    public const nint SYS_EPOLL_CREATE  = 213;
    public const nint SYS_EPOLL_CTL_OLD = 214;
    public const nint SYS_EPOLL_WAIT_OLD = 215;
    public const nint SYS_REMAP_FILE_PAGES = 216;
    public const nint SYS_GETDENTS64    = 217;
    public const nint SYS_SET_TID_ADDRESS = 218;
    public const nint SYS_RESTART_SYSCALL = 219;
    public const nint SYS_SEMTIMEDOP    = 220;
    public const nint SYS_FADVISE64     = 221;
    public const nint SYS_TIMER_CREATE  = 222;
    public const nint SYS_TIMER_SETTIME = 223;
    public const nint SYS_TIMER_GETTIME = 224;
    public const nint SYS_TIMER_GETOVERRUN = 225;
    public const nint SYS_TIMER_DELETE  = 226;
    public const nint SYS_CLOCK_SETTIME = 227;
    public const nint SYS_CLOCK_GETTIME = 228;
    public const nint SYS_CLOCK_GETRES  = 229;
    public const nint SYS_CLOCK_NANOSLEEP = 230;
    public const nint SYS_EXIT_GROUP    = 231;
    public const nint SYS_EPOLL_WAIT    = 232;
    public const nint SYS_EPOLL_CTL     = 233;
    public const nint SYS_TGKILL        = 234;
    public const nint SYS_UTIMES        = 235;
    public const nint SYS_VSERVER       = 236;
    public const nint SYS_MBIND         = 237;
    public const nint SYS_SET_MEMPOLICY = 238;
    public const nint SYS_GET_MEMPOLICY = 239;
    public const nint SYS_MQ_OPEN       = 240;
    public const nint SYS_MQ_UNLINK     = 241;
    public const nint SYS_MQ_TIMEDSEND  = 242;
    public const nint SYS_MQ_TIMEDRECEIVE = 243;
    public const nint SYS_MQ_NOTIFY     = 244;
    public const nint SYS_MQ_GETSETATTR = 245;
    public const nint SYS_KEXEC_LOAD    = 246;
    public const nint SYS_WAITID        = 247;
    public const nint SYS_ADD_KEY       = 248;
    public const nint SYS_REQUEST_KEY   = 249;
    public const nint SYS_KEYCTL        = 250;
    public const nint SYS_IOPRIO_SET    = 251;
    public const nint SYS_IOPRIO_GET    = 252;
    public const nint SYS_INOTIFY_INIT  = 253;
    public const nint SYS_INOTIFY_ADD_WATCH = 254;
    public const nint SYS_INOTIFY_RM_WATCH = 255;
    public const nint SYS_MIGRATE_PAGES = 256;
    public const nint SYS_OPENAT        = 257;
    public const nint SYS_MKDIRAT       = 258;
    public const nint SYS_MKNODAT       = 259;
    public const nint SYS_FCHOWNAT      = 260;
    public const nint SYS_FUTIMESAT     = 261;
    public const nint SYS_NEWFSTATAT    = 262;
    public const nint SYS_UNLINKAT      = 263;
    public const nint SYS_RENAMEAT      = 264;
    public const nint SYS_LINKAT        = 265;
    public const nint SYS_SYMLINKAT     = 266;
    public const nint SYS_READLINKAT    = 267;
    public const nint SYS_FCHMODAT      = 268;
    public const nint SYS_FACCESSAT     = 269;
    public const nint SYS_PSELECT6      = 270;
    public const nint SYS_PPOLL         = 271;
    public const nint SYS_UNSHARE       = 272;
    public const nint SYS_SET_ROBUST_LIST = 273;
    public const nint SYS_GET_ROBUST_LIST = 274;
    public const nint SYS_SPLICE        = 275;
    public const nint SYS_TEE           = 276;
    public const nint SYS_SYNC_FILE_RANGE = 277;
    public const nint SYS_VMSPLICE      = 278;
    public const nint SYS_MOVE_PAGES    = 279;
    public const nint SYS_UTIMENSAT     = 280;
    public const nint SYS_EPALL_PWAIT   = 281;
    public const nint SYS_SIGNALFD      = 282;
    public const nint SYS_TIMERFD_CREATE = 283;
    public const nint SYS_EVENTFD       = 284;
    public const nint SYS_FALLOCATE     = 285;
    public const nint SYS_TIMERFD_SETTIME = 286;
    public const nint SYS_TIMERFD_GETTIME = 287;
    public const nint SYS_ACCEPT4       = 288;
    public const nint SYS_SIGNALFD4     = 289;
    public const nint SYS_EVENTFD2      = 290;
    public const nint SYS_EPOLL_CREATE1 = 291;
    public const nint SYS_DUP3          = 292;
    public const nint SYS_PIPE2         = 293;
    public const nint SYS_INOTIFY_INIT1 = 294;
    public const nint SYS_PREADV        = 295;
    public const nint SYS_PWRITEV       = 296;
    public const nint SYS_RT_TGSIGQUEUEINFO = 297;
    public const nint SYS_PERF_EVENT_OPEN = 298;
    public const nint SYS_RECVMMSG      = 299;
    public const nint SYS_FANOTIFY_INIT = 300;
    public const nint SYS_FANOTIFY_MARK = 301;
    public const nint SYS_PRLIMIT64     = 302;
    public const nint SYS_NAME_TO_HANDLE_AT = 303;
    public const nint SYS_OPEN_BY_HANDLE_AT = 304;
    public const nint SYS_CLOCK_ADJTIME = 305;
    public const nint SYS_SYNCFS        = 306;
    public const nint SYS_SENDMMSG      = 307;
    public const nint SYS_SETNS         = 308;
    public const nint SYS_GETCPU        = 309;
    public const nint SYS_PROCESS_VM_READV = 310;
    public const nint SYS_PROCESS_VM_WRITEV = 311;
    public const nint SYS_KCMP          = 312;
    public const nint SYS_FINIT_MODULE  = 313;
    public const nint SYS_SCHED_SETATTR = 314;
    public const nint SYS_SCHED_GETATTR = 315;
    public const nint SYS_RENAMEAT2     = 316;
    public const nint SYS_SECCOMP       = 317;
    public const nint SYS_GETRANDOM     = 318;
    public const nint SYS_MEMFD_CREATE  = 319;
    public const nint SYS_KEXEC_FILE_LOAD = 320;
    public const nint SYS_BPF           = 321;
    public const nint SYS_EXECVEAT      = 322;
    public const nint SYS_USERFAULTFD   = 323;
    public const nint SYS_MEMBARRIER    = 324;
    public const nint SYS_MLOCK2        = 325;
    public const nint SYS_COPY_FILE_RANGE = 326;
    public const nint SYS_PREADV2       = 327;
    public const nint SYS_PWRITEV2      = 328;
    public const nint SYS_PKEY_MPROTECT = 329;
    public const nint SYS_PKEY_ALLOC    = 330;
    public const nint SYS_PKEY_FREE     = 331;
    public const nint SYS_STATX         = 332;
    public const nint SYS_IO_URING_SETUP    = 425;
    public const nint SYS_IO_URING_ENTER    = 426;
    public const nint SYS_IO_URING_REGISTER = 427;
    public const nint SYS_OPENAT2       = 437;
    public const nint SYS_CLOSE_RANGE   = 436;
    public const nint SYS_PIDFD_OPEN    = 434;
    public const nint SYS_PIDFD_SEND_SIGNAL = 424;
    public const nint SYS_PIDFD_GETFD   = 438;
    public const nint SYS_FACCESSAT2    = 439;
    public const nint SYS_PROCESS_MADVISE = 440;
    public const nint SYS_EPOLL_PWAIT2  = 441;
    public const nint SYS_MOUNT_SETATTR = 442;
    public const nint SYS_QUOTACTL_FD   = 443;
    public const nint SYS_LANDLOCK_CREATE_RULESET = 444;
    public const nint SYS_LANDLOCK_ADD_RULE = 445;
    public const nint SYS_LANDLOCK_RESTRICT_SELF = 446;
    public const nint SYS_MEMFD_SECRET  = 447;
    public const nint SYS_PROCESS_MRELEASE = 448;
    public const int STDIN_FILENO  = 0;
    public const int STDOUT_FILENO = 1;
    public const int STDERR_FILENO = 2;
    public const int PROT_NONE      = 0x0;
    public const int PROT_READ      = 0x1;
    public const int PROT_WRITE     = 0x2;
    public const int PROT_EXEC      = 0x4;
    public const int MAP_SHARED     = 0x01;
    public const int MAP_PRIVATE    = 0x02;
    public const int MAP_FIXED      = 0x10;
    public const int MAP_ANONYMOUS  = 0x20;
    public const int EPOLLIN        = 0x001;
    public const int EPOLLPRI       = 0x002;
    public const int EPOLLOUT       = 0x004;
    public const int EPOLLERR       = 0x008;
    public const int EPOLLHUP       = 0x010;
    public const int EPOLLRDHUP     = 0x2000;
    public const int EPOLLEXCLUSIVE = 1 << 28;
    public const int EPOLLWAKEUP    = 1 << 29;
    public const int EPOLLONESHOT   = 1 << 30;
    public const int EPOLLET        = 1 << 31;
    public const int EPOLL_CTL_ADD  = 1;
    public const int EPOLL_CTL_DEL  = 2;
    public const int EPOLL_CTL_MOD  = 3;
    public const uint IORING_SETUP_IOPOLL     = 1U << 0;
    public const uint IORING_SETUP_SQPOLL     = 1U << 1;
    public const uint IORING_SETUP_SQ_AFF     = 1U << 2;
    public const uint IORING_SETUP_CQSIZE     = 1U << 3;
    public const uint IORING_SETUP_CLAMP      = 1U << 4;
    public const uint IORING_SETUP_ATTACH_WQ  = 1U << 5;
    public const uint IORING_SETUP_R_DISABLED = 1U << 6;
    public const uint IORING_SETUP_SUBMIT_ALL = 1U << 7;
    public const uint IORING_SETUP_COOP_TASKRUN = 1U << 8;
    public const uint IORING_SETUP_TASKRUN_FLAG = 1U << 9;
    public const uint IORING_SETUP_SQE128     = 1U << 10;
    public const uint IORING_SETUP_CQE32      = 1U << 11;
    public const byte IORING_OP_NOP             = 0;
    public const byte IORING_OP_READV           = 1;
    public const byte IORING_OP_WRITEV          = 2;
    public const byte IORING_OP_FSYNC           = 3;
    public const byte IORING_OP_READ_FIXED      = 4;
    public const byte IORING_OP_WRITE_FIXED     = 5;
    public const byte IORING_OP_POLL_ADD        = 6;
    public const byte IORING_OP_POLL_REMOVE     = 7;
    public const byte IORING_OP_SYNC_FILE_RANGE = 8;
    public const byte IORING_OP_SENDMSG         = 9;
    public const byte IORING_OP_RECVMSG         = 10;
    public const byte IORING_OP_TIMEOUT         = 11;
    public const byte IORING_OP_TIMEOUT_REMOVE  = 12;
    public const byte IORING_OP_ACCEPT          = 13;
    public const byte IORING_OP_ASYNC_CANCEL    = 14;
    public const byte IORING_OP_LINK_TIMEOUT    = 15;
    public const byte IORING_OP_CONNECT         = 16;
    public const byte IORING_OP_FALLOCATE       = 17;
    public const byte IORING_OP_OPENAT          = 18;
    public const byte IORING_OP_CLOSE           = 19;
    public const byte IORING_OP_FILES_UPDATE    = 20;
    public const byte IORING_OP_STATX           = 21;
    public const byte IORING_OP_READ            = 22;
    public const byte IORING_OP_WRITE           = 23;
    public const byte IORING_OP_FADVISE         = 24
    ;public const byte IORING_OP_MADVISE         = 25;
    public const byte IORING_OP_SEND            = 26;
    public const byte IORING_OP_RECV            = 27;
    public const byte IORING_OP_OPENAT2         = 28;
    public const byte IORING_OP_EPOLL_CTL       = 29;
    public const byte IORING_OP_SPLICE          = 30;
    public const byte IORING_OP_PROVIDE_BUFFERS = 31;
    public const byte IORING_OP_REMOVE_BUFFERS  = 32;
    public const byte IORING_OP_TEE             = 33;
    public const byte IORING_OP_SHUTDOWN        = 34;
    public const byte IORING_OP_RENAMEAT        = 35;
    public const byte IORING_OP_UNLINKAT        = 36;
    public const byte IORING_OP_MKDIRAT         = 37;
    public const byte IORING_OP_SYMLINKAT       = 38;
    public const byte IORING_OP_LINKAT          = 39;
    public const int AF_UNSPEC   = 0;
    public const int AF_UNIX     = 1;
    public const int AF_LOCAL    = 1;
    public const int AF_INET     = 2;
    public const int AF_AX25     = 3;
    public const int AF_IPX      = 4;
    public const int AF_APPLETALK = 5;
    public const int AF_NETROM   = 6;
    public const int AF_BRIDGE   = 7;
    public const int AF_ATMPVC   = 8;
    public const int AF_X25      = 9;
    public const int AF_INET6    = 10;
    public const int AF_ROSE     = 11;
    public const int AF_DECnet   = 12;
    public const int AF_NETBEUI  = 13;
    public const int AF_SECURITY = 14;
    public const int AF_KEY      = 15;
    public const int AF_NETLINK  = 16;
    public const int AF_ROUTE    = 16;
    public const int AF_PACKET   = 17;
    public const int SOCK_STREAM    = 1;
    public const int SOCK_DGRAM     = 2;
    public const int SOCK_RAW       = 3;
    public const int SOCK_RDM       = 4;
    public const int SOCK_SEQPACKET = 5;
    public const int SOCK_DCCP      = 6;
    public const int SOCK_PACKET    = 10;
    public const int SOCK_CLOEXEC   = 0x80000;
    public const int SOCK_NONBLOCK  = 0x00800;
    public const int SOL_SOCKET = 1;
    public const int SO_DEBUG       = 1;
    public const int SO_REUSEADDR   = 2;
    public const int SO_TYPE        = 3;
    public const int SO_ERROR       = 4;
    public const int SO_DONTROUTE   = 5;
    public const int SO_BROADCAST   = 6;
    public const int SO_SNDBUF      = 7;
    public const int SO_RCVBUF      = 8;
    public const int SO_KEEPALIVE   = 9;
    public const int SO_OOBINLINE   = 10;
    public const int SO_NO_CHECK    = 11;
    public const int SO_PRIORITY    = 12;
    public const int SO_LINGER      = 13;
    public const int SO_BSDCOMPAT   = 14;
    public const int SO_REUSEPORT   = 15;
    public const int SO_PASSCRED    = 16;
    public const int SO_PEERCRED    = 17;
    public const int SO_RCVLOWAT    = 18;
    public const int SO_SNDLOWAT    = 19;
    public const int SO_RCVTIMEO    = 20;
    public const int SO_SNDTIMEO    = 21;
    public const nint SYS_FUTEX_WAITV         = 449;
    public const nint SYS_SET_MEMPOLICY_HOME  = 450;
    public const nint SYS_CACHESTAT           = 451;
    public const nint SYS_FCHMODAT2           = 452;
    public const nint SYS_MAP_SHADOW_STACK    = 453;

    [StructLayout(LayoutKind.Sequential)]
    public struct timespec {
        public nint tv_sec;
        public nint tv_nsec;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct timeval {
        public nint tv_sec;
        public nint tv_usec;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct epoll_data {
        [FieldOffset(0)] public void* ptr;
        [FieldOffset(0)] public int fd;
        [FieldOffset(0)] public uint u32;
        [FieldOffset(0)] public ulong u64;

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct epoll_event {
        public uint events;
        public epoll_data data;

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct io_uring_sqe {
        public byte opcode;
        public byte flags;
        public ushort ioprio;
        public int fd;
        public ulong off;
        public ulong addr;
        public uint len;
        public uint rw_flags;
        public ulong user_data;
        public ushort buf_index;
        public ushort personality;
        public uint splice_fd_in;
        public uint __pad2_1;
        public ulong __pad2_2;

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct io_uring_cqe {
        public ulong user_data;
        public int res;
        public uint flags;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct io_uring_params {
        public uint sq_entries;
        public uint cq_entries;
        public uint flags;
        public uint sq_thread_cpu;
        public uint sq_thread_idle;
        public uint features;
        public uint wq_fd;
        public uint resv_1;
        public uint resv_2;
        public uint resv_3;
        public io_sqring_offsets sq_off;
        public io_cqring_offsets cq_off;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct io_sqring_offsets {
        public uint head;
        public uint tail;
        public uint array;
        public uint flags;
        public uint dropped;
        public uint array_index;
        public uint resv1;
        public uint resv2;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct io_cqring_offsets {
        public uint head;
        public uint tail;
        public uint overflow;
        public uint cqes;
        public uint flags;
        public uint resv1;
        public uint resv2;

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sockaddr {
        public ushort sa_family;
        public fixed byte sa_data[14];

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sockaddr_in {
        public ushort sin_family;
        public ushort sin_port;
        public uint sin_addr;
        public fixed byte sin_zero[8];

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sockaddr_in6 {
        public ushort sin6_family;
        public ushort sin6_port;
        public uint sin6_flowinfo;
        public fixed byte sin6_addr[16];
        public uint sin6_scope_id;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct iovec {
        public void* iov_base;
        public nuint iov_len;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct msghdr {
        public void* msg_name;
        public uint msg_namelen;
        public iovec* msg_iov;
        public nuint msg_iovlen;
        public void* msg_control;
        public nuint msg_controllen;
        public int msg_flags;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct mmsghdr {
        public msghdr msg_hdr;
        public uint msg_len;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct pollfd {
        public int fd;
        public short events;
        public short revents;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct stat {
        public ulong st_dev;
        public ulong st_ino;
        public ulong st_nlink;
        public uint st_mode;
        public uint st_uid;
        public uint st_gid;
        public int __pad0;
        public ulong st_rdev;
        public long st_size;
        public long st_blksize;
        public long st_blocks;
        public timespec st_atim;
        public timespec st_mtim;
        public timespec st_ctim;
        public fixed long __glibc_reserved[3];

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct futex_waitv {
        public ulong val;
        public void* uaddr;
        public uint flags;
        public uint __reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct cachestat_range {
        public ulong off;
        public ulong len;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct cachestat {
        public ulong nr_cache;
        public ulong nr_dirty;
        public ulong nr_writeback;
        public ulong nr_evicted;
        public ulong nr_recently_evicted;
    }

    public struct nfds_t {
        public nuint Value;
        public static implicit operator nuint(nfds_t wrapper) => wrapper.Value;public static implicit operator nfds_t(nuint value) => new nfds_t {
            Value = value
        };
    }

    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, nint arg2);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, nint arg2, nint arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, nint arg2, nint arg3, nint arg4);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5, nint arg6);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, byte* arg2, nuint arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, nint arg2, epoll_event* arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, io_uring_params* arg2, nint arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, io_uring_sqe* arg2, uint arg3, uint arg4, nint arg5);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, sockaddr* arg2, nint arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, sockaddr* arg2, int* arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, iovec* arg2, nuint arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, msghdr* arg2, int arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, pollfd* arg1, nfds_t arg2, int arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, timespec* arg1, timespec* arg2);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, int arg1, stat* arg2);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, void* arg2, nuint arg3);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, nint arg1, void* arg2, void* arg3, uint arg4);
    [LibraryImport("libc.so.6", EntryPoint = "syscall")] public static partial nint Syscall(nint number, void* arg1, uint arg2, uint arg3, void* arg4, uint arg5);

}
