// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

namespace Generator.Tables {
	[TypeGen(TypeGenOrders.NoDeps)]
	sealed class MemorySizeDefs {
		public readonly MemorySizeDef[] Defs;

		MemorySizeDefs(GenTypes genTypes) {
			Defs = CreateDefs(genTypes);
			genTypes.AddObject(TypeIds.MemorySizeDefs, this);
		}

		static MemorySizeDef[] CreateDefs(GenTypes genTypes) {
			var filename = genTypes.Dirs.GetGeneratorFilename("Tables", "MemorySizeDefs.txt");
			var reader = new MemorySizeDefsReader(genTypes, filename);
			return reader.Read();
		}
	}
}
