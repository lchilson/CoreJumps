# Exercise 5 — Create a second object with its own state

Goal: Build a second kind of object that uses the same idea as `Product`, but keeps separate state.

Steps:
1. Open `CSharpBasics/Product.cs` and review the `Product` class.
2. Create a new class in a new file, for example `ShoppingCartItem.cs`.
3. Give it properties such as:

```csharp
public string ProductName { get; set; } = string.Empty;
public int Quantity { get; set; }
public decimal Price { get; set; }
```

4. Add a method that calculates the line total:

```csharp
public decimal GetLineTotal()
{
    return Quantity * Price;
}
```

5. In `Program.cs`, create two cart items and print each line total.

Hints:
- Each object should hold its own values.
- A class is a blueprint, and an object is a specific instance with its own state.

Verify:
- Run the app and confirm each item keeps its own quantity and price values.

This exercise is preparing the learner for the later examples in `Interfaces.cs` and `Inheritance.cs`, which are more advanced patterns.
