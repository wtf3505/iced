// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

// ⚠️This file was generated by GENERATOR!🦹‍♂️

#nullable enable

#if FAST_FMT
using System;

namespace Iced.Intel.FastFormatterInternal {
	[Flags]
	enum FastFmtFlags : byte {
		None = 0x00000000,
		HasVPrefix = 0x00000001,
		SameAsPrev = 0x00000002,
		ForceMemSize = 0x00000004,
		PseudoOpsKindShift = 0x00000003,
		cmpps = 0x00000008,
		vcmpps = 0x00000010,
		cmppd = 0x00000018,
		vcmppd = 0x00000020,
		cmpss = 0x00000028,
		vcmpss = 0x00000030,
		cmpsd = 0x00000038,
		vcmpsd = 0x00000040,
		pclmulqdq = 0x00000048,
		vpclmulqdq = 0x00000050,
		vpcomb = 0x00000058,
		vpcomw = 0x00000060,
		vpcomd = 0x00000068,
		vpcomq = 0x00000070,
		vpcomub = 0x00000078,
		vpcomuw = 0x00000080,
		vpcomud = 0x00000088,
		vpcomuq = 0x00000090,
	}
}
#endif
