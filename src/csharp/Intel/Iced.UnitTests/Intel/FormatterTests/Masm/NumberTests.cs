// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

#if MASM
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Masm {
	public sealed class NumberTests : FormatterTests.NumberTests {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, object number, string[] formattedStrings) => FormatBase(index, number, formattedStrings, FormatterFactory.Create_Numbers());
		public static IEnumerable<object[]> Format_Data => GetFormatData();
	}
}
#endif
