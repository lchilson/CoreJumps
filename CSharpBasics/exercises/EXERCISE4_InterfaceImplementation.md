# Exercise 4 — Add a constructor and initialize state

Goal: Give each `Product` a sensible default state when it is created.

Steps:
1. Open `CSharpBasics/Product.cs`.
2. Look at the constructor:

```csharp
public Product(string name, decimal price)
{
    Name = name;
    Price = price;
}
```

3. Add an initialization that also sets the status and a safe default description:

```csharp
public Product(string name, decimal price)
{
    Name = name;
    Price = price;
    Status = ProductStatus.Draft;
    Description = string.Empty;
}
```

4. Update `Program.cs` to create a product in a way that clearly shows the starting state.

Hints:
- A constructor runs when you create an object with `new`.
- It is a great place to make sure the object starts in a valid state.

Verify:
- Run the app and confirm each newly created product starts with a sensible default state.

Late-lesson idea: after this, revisit the interface and repository examples in `Interfaces.cs` as a more advanced design pattern.
