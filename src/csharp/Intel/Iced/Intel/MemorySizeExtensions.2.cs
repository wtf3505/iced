// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

#if INSTR_INFO || ENCODER || FAST_FMT
namespace Iced.Intel {
	/// <summary>
	/// <see cref="MemorySize"/> extension methods
	/// </summary>
	public static partial class MemorySizeExtensions {
		/// <summary>
		/// Checks if <paramref name="memorySize"/> is a broadcast memory type
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static bool IsBroadcast(this MemorySize memorySize) => memorySize >= IcedConstants.FirstBroadcastMemorySize;
	}
}
#endif
