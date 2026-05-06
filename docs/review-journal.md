# Review Journal

The review surface for `lumen-sim-queue-flow` is deliberately narrow: one fixture, one scoring rule, and one local check.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 215, lane `ship`
- `stress`: `state drift`, score 216, lane `ship`
- `edge`: `review cost`, score 124, lane `watch`
- `recovery`: `decision risk`, score 236, lane `ship`
- `stale`: `input pressure`, score 178, lane `ship`

## Note

The repository should be understandable without pretending it is larger than it is.
