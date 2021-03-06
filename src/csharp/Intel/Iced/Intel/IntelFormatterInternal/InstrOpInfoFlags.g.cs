// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

// ⚠️This file was generated by GENERATOR!🦹‍♂️

#nullable enable

#if INTEL
using System;

namespace Iced.Intel.IntelFormatterInternal {
	[Flags]
	enum InstrOpInfoFlags : ushort {
		None = 0x00000000,
		MemSize_Nothing = 0x00000001,
		ShowNoMemSize_ForceSize = 0x00000002,
		ShowMinMemSize_ForceSize = 0x00000004,
		BranchSizeInfoShift = 0x00000003,
		BranchSizeInfoMask = 0x00000001,
		BranchSizeInfo_Short = 0x00000008,
		SizeOverrideMask = 0x00000003,
		OpSizeShift = 0x00000004,
		OpSize16 = 0x00000010,
		OpSize32 = 0x00000020,
		OpSize64 = 0x00000030,
		AddrSizeShift = 0x00000006,
		AddrSize16 = 0x00000040,
		AddrSize32 = 0x00000080,
		AddrSize64 = 0x000000C0,
		IgnoreOpMask = 0x00000100,
		FarMnemonic = 0x00000200,
		JccNotTaken = 0x00000400,
		JccTaken = 0x00000800,
		BndPrefix = 0x00001000,
		IgnoreIndexReg = 0x00002000,
		IgnoreSegmentPrefix = 0x00004000,
		MnemonicIsDirective = 0x00008000,
	}
}
#endif
