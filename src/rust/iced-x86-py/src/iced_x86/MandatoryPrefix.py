# SPDX-License-Identifier: MIT
# Copyright wtfsckgh@gmail.com
# Copyright iced contributors

# ⚠️This file was generated by GENERATOR!🦹‍♂️

# pylint: disable=invalid-name
# pylint: disable=line-too-long
# pylint: disable=too-many-lines

"""
Mandatory prefix
"""

from typing import List

NONE: int = 0
"""
No mandatory prefix (legacy and 3DNow! tables only)
"""
PNP: int = 1
"""
Empty mandatory prefix (no ``66``, ``F3`` or ``F2`` prefix)
"""
P66: int = 2
"""
``66`` prefix
"""
PF3: int = 3
"""
``F3`` prefix
"""
PF2: int = 4
"""
``F2`` prefix
"""

__all__: List[str] = []
