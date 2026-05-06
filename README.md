# lumen-sim-queue-flow

`lumen-sim-queue-flow` is a C# project in simulations. Its focus is to create a C# reference implementation for queue workflows, centered on diagnostic reporting, negative fixtures, and human-readable error snapshots.

## Why I Keep It Small

The point is to make a small domain rule concrete enough that a reader can change it and immediately see what broke.

## Lumen Sim Queue Flow Review Notes

Start with `decision risk` and `review cost`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Included Behavior

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/lumen-sim-queue-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `decision risk` and `review cost`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Internal Model

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `input pressure`, `state drift`, `review cost`, and `decision risk`.

The C# addition stays small enough to inspect in one sitting.

## Try It Locally

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Validation

The check exercises the source code and the review fixture. `recovery` is the high score at 236; `edge` is the low score at 124.

## Scope

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
