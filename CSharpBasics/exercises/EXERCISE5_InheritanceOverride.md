# Exercise 5 — Inheritance and override

Goal: Add a new derived class `PhysicalProduct` that extends `Product` and adds `Weight`.

Steps:
1. Create `PhysicalProduct` in `Inheritance.cs` or a new file.
2. Add a `public decimal Weight { get; set; }` property.
3. Override `CalculateTax` to make tax depend on weight (toy example):

```csharp
public override decimal CalculateTax(decimal taxRate)
{
    return Price * taxRate + Weight * 0.01m; // extra tax per unit weight
}
```

4. In `Program.cs`, create a `PhysicalProduct` and print its tax.

Verify:
- Run the app and confirm the overridden tax value appears.
