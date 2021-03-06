// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

#![allow(clippy::let_and_return)]

use std::collections::HashSet;

lazy_static! {
	pub(super) static ref IGNORED_CODE_HASH: HashSet<&'static str> = {
		// GENERATOR-BEGIN: CodeHash
		// ⚠️This was generated by GENERATOR!🦹‍♂️
		let h: HashSet<&'static str> = HashSet::new();
		// GENERATOR-END: CodeHash
		h
	};
}
