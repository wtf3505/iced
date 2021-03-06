// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

#if INTEL
using System.Collections.Generic;
using Iced.Intel;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class RegisterTests : FormatterTests.RegisterTests {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(Register register, string formattedString) => FormatBase(register, formattedString, FormatterFactory.Create_Registers());
		public static IEnumerable<object[]> Format_Data => GetFormatData("Intel", "RegisterTests");
	}
}
#endif
