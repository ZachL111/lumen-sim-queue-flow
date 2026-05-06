# Lumen Sim Queue Flow Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 215 | ship |
| stress | state drift | 216 | ship |
| edge | review cost | 124 | watch |
| recovery | decision risk | 236 | ship |
| stale | input pressure | 178 | ship |

Start with `recovery` and `edge`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

The next useful expansion would be a malformed fixture around state drift and decision risk.
