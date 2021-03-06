# SPDX-License-Identifier: MIT
# Copyright wtfsckgh@gmail.com
# Copyright iced contributors

# ⚠️This file was generated by GENERATOR!🦹‍♂️

# pylint: disable=invalid-name
# pylint: disable=line-too-long
# pylint: disable=too-many-lines

"""
Mnemonic condition code selector (eg. ``JB`` / ``JC`` / ``JNAE``)
"""

from typing import List

B: int = 0
"""
``JB``, ``CMOVB``, ``SETB``
"""
C: int = 1
"""
``JC``, ``CMOVC``, ``SETC``
"""
NAE: int = 2
"""
``JNAE``, ``CMOVNAE``, ``SETNAE``
"""

__all__: List[str] = []
