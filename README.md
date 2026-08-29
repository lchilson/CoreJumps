# C# Socratic Full-Stack Learning Agents

A VS Code + GitHub Copilot workspace for teaching a true beginner C# and full-stack development through guided discovery instead of answer dumping.

## What is included

This repo includes seven VS Code custom agents:

1. **Workshop Guide** — VS Code, Visual Studio, terminal, files, .NET SDK, projects, debugging, Git.
2. **C# Socratic Tutor** — C# fundamentals through objects, interfaces, DI, exceptions, and async.
3. **Debugging Coach** — teaches systematic debugging instead of immediately fixing errors.
4. **Web Foundations Coach** — HTTP, REST, JSON, ASP.NET Core, APIs, DTOs, and persistence.
5. **Full-Stack Builder** — evolves one web-store project from console app to API to frontend.
6. **Engineering Reviewer** — makes the learner explain decisions, state, ownership, tests, and tradeoffs.
7. **Teacher Learning Manager** — teacher-facing orchestration agent for assessment, progress updates, lesson planning, and adapting outside starter templates.

The repository also contains:

- shared Copilot instructions
- a student progress file
- a curriculum
- a project roadmap
- Windows PowerShell setup scripts
- a VS Code workspace file

## Requirements

Install:

- Visual Studio Code
- GitHub Copilot / Copilot Chat in VS Code
- .NET SDK 10 or a current supported .NET SDK
- Git

Later, when the learner reaches frontend work:

- Node.js LTS
- npm

## Open it

1. Extract this zip.
2. Open the extracted folder in VS Code.
3. Sign into GitHub Copilot.
4. Open Copilot Chat.
5. Choose an agent from the agent dropdown.

VS Code automatically discovers repository-level custom agents from:

`.github/agents`

## Recommended first interaction

Choose **Workshop Guide** and say:

> I have never programmed before. Start with figuring out what I already have installed. Do not assume I know what a terminal, SDK, project, compiler, or runtime is.

## Create the starter projects

Open a PowerShell terminal in the repo and run:

```powershell
./scripts/setup.ps1
```

This creates:

```text
src/
  Store.Console/
  Store.Api/
tests/
  Store.Console.Tests/
  Store.Api.Tests/
SocraticStore.sln
```

The setup script deliberately creates only a small foundation. The teaching agents should grow the application with the learner instead of dumping a complete architecture on day one.

## Student progress

The file:

`student/LEARNER-PROGRESS.md`

is the shared teaching memory for the repository.

Agents should update it only when the learner has demonstrated understanding, not simply because a topic was mentioned.

Example:

```text
Methods
Status: Demonstrated
Evidence: Learner extracted duplicated total calculation into a method and explained parameters and return value.
```

## Philosophy

The primary teaching loop is:

```text
Question
  ↓
Prediction
  ↓
Experiment
  ↓
Observation
  ↓
Explanation
  ↓
Application
```

The agents should avoid turning Socratic learning into a guessing game. If the learner is genuinely blocked, the agent explains the answer, demonstrates it, and then asks the learner to apply the idea.

## Suggested progression

```text
Computer + Tools
      ↓
C# Fundamentals
      ↓
State + Data Flow
      ↓
Objects + Responsibilities
      ↓
Debugging
      ↓
HTTP + APIs
      ↓
ASP.NET Core
      ↓
Persistence
      ↓
JavaScript
      ↓
TypeScript
      ↓
React
      ↓
Full-Stack Integration
      ↓
Testing + Architecture + Deployment
```

## Teaching note

This repository is designed for gradual learning, not for dumping a full language overview at once. Start with the simplest console concepts and only move to the richer examples after the learner can explain what is happening in plain language.

## Agent files

The custom agent definitions are located at:

```text
.github/agents/
```

They are ordinary Markdown files, so edit them however you want.

## Resetting the student

To restart for another learner:

1. Replace `student/LEARNER-PROGRESS.md` with the contents of `student/LEARNER-PROGRESS.template.md`.
2. Delete the learner-created source code if desired.
3. Run `scripts/setup.ps1` again if you want a clean starter solution.


## Teacher workflow

Choose **Teacher Learning Manager** when you want to manage the learning process rather than teach directly.

Useful prompts:

```text
Update progress from today's session:
He understands variables, but needed help with conditions. He independently wrote his first method and explained the parameter.
```

```text
Here is the starter template I'm using. Map it to his current progress and tell me what I should skip, simplify, or teach first.
```

```text
Based on LEARNER-PROGRESS.md, design our next 45-minute lesson.
```

```text
He says he understands classes. Give me a diagnostic exercise that proves whether he actually does.
```

When asked, the Teacher Learning Manager can edit `student/LEARNER-PROGRESS.md` so the student-facing agents pick up the updated state on their next interaction.
