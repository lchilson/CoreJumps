# Curriculum

## Phase 0 — Computer and Tooling

Goal: learner can navigate the development environment without treating it as magic.

Topics:

- files and folders
- file extensions
- terminal
- current directory
- VS Code vs Visual Studio
- .NET SDK
- compiler
- runtime
- solution
- project
- source file
- build
- run
- breakpoint
- Git basics

Graduation exercise:

Create a console project, deliberately introduce a syntax error, locate the compiler error, correct it, set a breakpoint, and explain what build and run do.

---

## Phase 1 — C# Fundamentals

Topics:

- statements
- values
- variables
- primitive types
- strings
- decimal
- bool
- operators
- conditions
- loops
- methods
- parameters
- return values
- scope
- collections

Project progression:

A command-line product catalog.

---

## Phase 2 — State and Objects

Topics:

- state
- transitions
- class
- object
- property
- constructor
- encapsulation
- invariants
- composition
- interface

Project progression:

Products, inventory, shopping cart.

Example state transition:

```text
Cart Total = $40
     |
     | Add $15 item
     v
Cart Total = $55
```

---

## Phase 3 — Engineering C#

Topics:

- exceptions
- validation
- nullable values
- dependency injection
- async/await
- file I/O
- testing
- refactoring

Project progression:

Separate product behavior from console input/output and persist simple data.

---

## Phase 4 — Web Foundations

Topics:

- client/server
- DNS at a basic level
- URL
- HTTP
- method
- route
- header
- body
- status code
- JSON
- REST-style resources

Exercises:

Reason through:

```text
GET /products
GET /products/42
POST /products
PUT /products/42
DELETE /products/42
```

---

## Phase 5 — ASP.NET Core

Topics:

- application startup
- dependency injection container
- endpoint routing
- controller/minimal API concepts
- DTOs
- validation
- status codes
- services
- logging
- configuration
- Swagger/OpenAPI

Project:

Move the product catalog behind an HTTP API.

---

## Phase 6 — Persistence

Topics:

- relational data
- table
- row
- primary key
- foreign key
- SQL basics
- Entity Framework Core
- DbContext
- migrations
- async database access

Project:

Products, carts, and orders survive application restarts.

---

## Phase 7 — Browser Foundations

Topics:

- HTML
- CSS
- DOM
- browser dev tools
- JavaScript
- events
- promises
- fetch

Project:

A plain browser page that calls the store API.

---

## Phase 8 — TypeScript

Topics:

- type annotations
- interfaces/types
- unions
- optional values
- generics at a useful level
- compile-time vs runtime types

Project:

Convert the browser client to TypeScript.

---

## Phase 9 — React

Topics:

- component
- props
- state
- events
- rendering
- effects
- API calls
- derived state
- forms

Project:

Storefront UI.

---

## Phase 10 — Full-Stack Engineering

Topics:

- authentication concepts
- authorization concepts
- validation boundaries
- API contracts
- error handling
- structured logging
- unit tests
- integration tests
- end-to-end thinking
- Git branches and pull requests
- CI/CD concepts
- deployment
- observability

Final project:

A deployable web store whose architecture the learner can explain end-to-end.
