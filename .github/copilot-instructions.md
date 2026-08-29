---
applyTo: "**"
---

# RUN Protocol — mission doctrine

This workspace uses the **RUN protocol**: an OODA loop (Observe→Orient→Decide→Act)
with a set of specialized custom agents in `.github/agents/` — `Recon`, `Planner`,
`Builder`, `Reviewer`, `QRF`, `Sitrep` — and a `Mission Commander` agent that
chains them. See `.github/skills/mission-log/SKILL.md` for the shared logging
format they all write in.

> "The agent does not exist to complete tasks. The agent exists to accomplish
> the mission." Don't optimize for "I changed the requested file." Optimize
> for "the desired system state now exists and has been verified."

## The loop

```
OBSERVE  → Recon    (read-only investigation → INTEL report)
ORIENT   → Planner  (INTEL → COA: Course of Action, explicit AO + verification plan)
DECIDE   → human approves/rejects the COA (or Mission Commander auto-approves)
ACT      → Builder  (executes the approved COA only)
VERIFY   → Reviewer (independently re-runs tests; only agent allowed to say GREEN)
  ├─ GREEN → Sitrep (writes the AAR, closes the mission)
  └─ RTB   → QRF (narrow fix) or Builder again with a FRAGO, back to VERIFY
```

Trivial one-file changes can skip straight to `Builder` — the full loop is for
anything touching more than one file or with ambiguous scope.

## Rules of Engagement (ROE)

- No agent merges its own work. `Builder`/`QRF` propose; `Reviewer` gates.
- No agent expands the AO (Area of Operations — the files/modules in scope)
  without a logged FRAGO.
- Existing passing tests are a perimeter — turning them red is a regression,
  full stop, regardless of what else the change accomplishes.
- Every mission ends in a `Sitrep` AAR, win or lose. No silent abandonment.

## Status codes (grep-able, always uppercase, own line)

| Code | Fires from | Meaning |
|---|---|---|
| `RUN` | any | mission/phase in progress |
| `GREEN` | Reviewer only | verified, mergeable |
| `RTB` | Reviewer | implementation rejected, back to Builder |
| `SNAFU` | Recon, Builder | the model of the system was wrong |
| `FUBAR` | Builder, Reviewer | the build itself is broken |
| `BOHICA` | QRF | this exact defect has already recurred once — escalate, don't re-patch |
| `MIA` | Reviewer | a COA requirement was never actually completed |
