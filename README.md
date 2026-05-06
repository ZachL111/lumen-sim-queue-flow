# lumen-sim-queue-flow

`lumen-sim-queue-flow` is a C# project for Simulations. It turns create a C# reference implementation for queue workflows, centered on diagnostic reporting, negative fixtures, and human-readable error snapshots into a small local model with readable fixtures and a direct verification command.

## Reading Lumen Sim Queue Flow

Start with the README, then open `metadata/project.json` to check the constants behind the examples. After that, `fixtures/cases.csv` shows the compact path and `examples/extended_cases.csv` gives a wider look at the same rule.

## Purpose

The repository exists to keep a technical idea small enough to reason about. The implementation avoids external dependencies where possible, then uses fixtures to make changes easy to review.

## What It Does

- Models input state with deterministic scoring and explicit review decisions.
- Uses fixture data to keep policy checks changes visible in code review.
- Includes extended examples for fixture data, including `surge` and `degraded`.
- Documents local reports tradeoffs in `docs/operations.md`.
- Runs locally with a single verification command and no external credentials.

## Design Sketch

The core is a scoring model over demand, capacity, latency, risk, and weight. That keeps input state, policy checks, and fixture data in one explicit decision path. The threshold is 167, with risk penalty 4, latency penalty 2, and weight bonus 2. The C# code keeps the core model in a small static API and runs checks through the executable path.

## Files Worth Reading

- `src`: primary implementation
- `tests`: verification harness
- `fixtures`: compact golden scenarios
- `examples`: expanded scenario set
- `metadata`: project constants and verification metadata
- `docs`: operations and extension notes
- `scripts`: local verification and audit commands

## Setup

Use a normal shell with C# available on `PATH`. The verifier is written as a PowerShell script because the portfolio was assembled on Windows.

## Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

This runs the language-level build or test path against the compact fixture set.

## Verification

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/audit.ps1
```

The audit command checks repository structure and README constraints before it delegates to the verifier.

## Fixture Notes

The examples are meant to be readable before they are exhaustive. They cover enough variation to show how latency and risk can pull a decision below the threshold.

## Limits

This code is local-first. It makes no claim about deployed usage and avoids credentials, hosted state, and environment-specific setup.

## Next Directions

- Add a loader for `examples/extended_cases.csv` and promote selected cases into the language test suite.
- Add a short report command that prints the score breakdown for a single scenario.
- Add malformed input fixtures so the failure path is as visible as the happy path.
- Add one more simulations fixture that focuses on a malformed or borderline input.
