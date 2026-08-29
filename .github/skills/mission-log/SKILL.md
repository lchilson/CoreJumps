---
name: mission-log
description: Shared logging format for the RUN protocol (Recon, Planner, Builder, Reviewer, QRF, Sitrep custom agents). Use whenever writing a status update, handoff report, or MISSION_LOG.md entry so status codes and structure stay consistent and grep-able across a mission.
---

# Mission log — shared format

This is the formatting contract shared by the RUN protocol's custom agents
(`Recon`, `Planner`, `Builder`, `Reviewer`, `QRF`, `Sitrep`). It isn't a new
capability — it keeps every agent's output legible and consistent so a
running `MISSION_LOG.md` can be skimmed or grepped later.

## Rules

1. **Status codes are exact strings, uppercase, own line, prefixed `STATUS:`.**
   Valid values: `RUN`, `GREEN`, `RTB`, `SNAFU`, `FUBAR`, `BOHICA`, `MIA`.
   Never invent a new one — if nothing fits, use `RUN` and explain in prose.
2. **Every block is self-contained.** A reader should be able to grep one
   mission's blocks and reconstruct the whole cycle without other context.
3. **No filler.** Bullet findings, not paragraphs. If a section has nothing
   to report, write `none` rather than omitting the header.
4. **AO and ROE deltas are spelled out explicitly every time**, never implied
   by reference to an earlier block.

## Running mission log

Append each phase's block, in order, to `MISSION_LOG.md` at the repo root:

```
=== MISSION: <name> ===

--- RECON ---
<INTEL report>

--- PLAN ---
<COA proposal>

--- DECISION ---
APPROVED | REJECTED | REVISED — <one line if rejected/revised>

--- BUILD (cycle 1) ---
<EXECUTION report>

--- VERIFY (cycle 1) ---
<VERIFICATION SITREP>

--- BUILD (cycle 2, if RTB) ---
...

--- CLOSE ---
<AAR>

=== END MISSION ===
```

Multiple RTB/QRF cycles repeat the BUILD/VERIFY pair with an incrementing
cycle number — don't collapse prior cycles away, they're what makes the AAR's
LESSON line meaningful later.

## Quick reference

| Code | Fires from | Meaning |
|---|---|---|
| `RUN` | any | mission/phase in progress |
| `GREEN` | Reviewer only | verified, mergeable |
| `RTB` | Reviewer | implementation rejected, back to Builder |
| `SNAFU` | Recon, Builder | model of the system was wrong |
| `FUBAR` | Builder, Reviewer | the build itself is broken |
| `BOHICA` | QRF | this exact defect already recurred once |
| `MIA` | Reviewer | a COA requirement was never actually done |
