// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

// ⚠️This file was generated by GENERATOR!🦹‍♂️

#nullable enable

#if DECODER
namespace Iced.Intel {
	/// <summary>Decoder error</summary>
	public enum DecoderError {
		/// <summary>No error. The last decoded instruction is a valid instruction</summary>
		None = 0,
		/// <summary>It&apos;s an invalid instruction or an invalid encoding of an existing instruction (eg. some reserved bit is set/cleared)</summary>
		InvalidInstruction = 1,
		/// <summary>There&apos;s not enough bytes left to decode the instruction</summary>
		NoMoreBytes = 2,
	}
}
#endif
