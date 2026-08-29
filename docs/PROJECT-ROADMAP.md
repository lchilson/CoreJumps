# Web Store Learning Project

The learner should grow one system instead of completing disconnected tutorials.

## Milestone 1 — Product Console

Features:

- create products
- list products
- find a product
- basic inventory count

Concepts:

- variables
- conditions
- loops
- methods
- collections

## Milestone 2 — Domain Objects

Introduce:

- Product
- Cart
- CartItem

Concepts:

- classes
- objects
- state
- constructors
- encapsulation

## Milestone 3 — Services

Introduce:

- ProductService
- CartService

Only introduce interfaces when there is a concrete reason for interchangeable behavior or test isolation.

## Milestone 4 — Tests

Test:

- inventory cannot drop below zero
- cart totals are correct
- missing products are handled

## Milestone 5 — HTTP API

Endpoints:

```text
GET    /products
GET    /products/{id}
POST   /products
POST   /carts
POST   /carts/{id}/items
GET    /carts/{id}
```

## Milestone 6 — Database

Persist:

- Product
- Cart
- CartItem
- Order
- OrderItem

## Milestone 7 — Browser Client

Start with plain HTML/JavaScript.

Fetch:

```text
GET /products
```

Render the result.

## Milestone 8 — TypeScript

Convert frontend code and introduce explicit contracts.

## Milestone 9 — React

Create:

- ProductList
- ProductCard
- Cart
- CartItem
- Checkout

## Milestone 10 — Production Thinking

Add:

- validation
- error handling
- logging
- authentication concepts
- authorization concepts
- integration tests
- CI
- deployment
