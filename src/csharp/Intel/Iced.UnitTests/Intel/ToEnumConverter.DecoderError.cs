// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

using System;
using System.Collections.Generic;
using Iced.Intel;

namespace Iced.UnitTests.Intel {
	static partial class ToEnumConverter {
		public static bool TryDecoderError(string value, out DecoderError decoderError) => decoderErrorDict.TryGetValue(value, out decoderError);
		public static DecoderError GetDecoderError(string value) => TryDecoderError(value, out var decoderError) ? decoderError : throw new InvalidOperationException($"Invalid DecoderError value: {value}");

		static readonly Dictionary<string, DecoderError> decoderErrorDict =
			// GENERATOR-BEGIN: DecoderErrorHash
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			new Dictionary<string, DecoderError>(3, StringComparer.Ordinal) {
				{ "None", DecoderError.None },
				{ "InvalidInstruction", DecoderError.InvalidInstruction },
				{ "NoMoreBytes", DecoderError.NoMoreBytes },
			};
			// GENERATOR-END: DecoderErrorHash
	}
}
