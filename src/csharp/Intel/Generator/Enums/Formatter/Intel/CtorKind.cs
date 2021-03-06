// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

namespace Generator.Enums.Formatter.Intel {
	[Enum(nameof(CtorKind), "IntelCtorKind")]
	enum CtorKind {
		Previous,
		Normal_1,
		Normal_2,
		asz,
		StringIg0,
		StringIg1,
		bcst,
		bnd,
		ST2,
		DeclareData,
		ST_STi,
		STi_ST,
		imul,
		opmask_op,
		invlpga,
		maskmovq,
		memsize,
		movabs,
		nop,
		os2,
		os3,
		os_bnd,
		CC_1,
		CC_2,
		CC_3,
		os_jcc_a_1,
		os_jcc_a_2,
		os_jcc_a_3,
		os_jcc_b_1,
		os_jcc_b_2,
		os_jcc_b_3,
		os_loopcc,
		os_loop,
		pclmulqdq,
		pops,
		reg,
		Reg16,
		Reg32,
		ST1_2,
		ST1_3,
	}
}
