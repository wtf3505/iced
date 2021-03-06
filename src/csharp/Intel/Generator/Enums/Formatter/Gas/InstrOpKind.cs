// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

using System.Linq;

namespace Generator.Enums.Formatter.Gas {
	[TypeGen(TypeGenOrders.NoDeps)]
	sealed class InstrOpKindEnum {
		InstrOpKindEnum(GenTypes genTypes) {
			var enumType = new EnumType("InstrOpKind", TypeIds.GasInstrOpKind, null, GetValues(genTypes), EnumTypeFlags.NoInitialize);
			genTypes.Add(enumType);
		}

		static EnumValue[] GetValues(GenTypes genTypes) {
			var list = genTypes[TypeIds.OpKind].Values.Select(a => new EnumValue(a.Value, a.RawName, null)).ToList();
			// Extra opkinds
			list.Add(new EnumValue((uint)list.Count, "Sae", null));
			list.Add(new EnumValue((uint)list.Count, "RnSae", null));
			list.Add(new EnumValue((uint)list.Count, "RdSae", null));
			list.Add(new EnumValue((uint)list.Count, "RuSae", null));
			list.Add(new EnumValue((uint)list.Count, "RzSae", null));
			list.Add(new EnumValue((uint)list.Count, "DeclareByte", null));
			list.Add(new EnumValue((uint)list.Count, "DeclareWord", null));
			list.Add(new EnumValue((uint)list.Count, "DeclareDword", null));
			list.Add(new EnumValue((uint)list.Count, "DeclareQword", null));
			return list.ToArray();
		}
	}
}
