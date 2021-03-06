// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

#if INSTR_INFO
using System.Collections.Generic;
using Iced.Intel;
using Xunit;

namespace Iced.UnitTests.Intel.InstructionInfoTests {
	public sealed class InstructionInfoTest_64 : InstructionInfoTest {
		[Theory]
		[MemberData(nameof(Test64_InstructionInfo_Data))]
		void Test64_InstructionInfo(string hexBytes, Code code, DecoderOptions options, int lineNo, InstructionInfoTestCase testCase) =>
			TestInstructionInfo(64, hexBytes, code, options, lineNo, testCase);
		public static IEnumerable<object[]> Test64_InstructionInfo_Data => GetTestCases(64);
	}
}
#endif
