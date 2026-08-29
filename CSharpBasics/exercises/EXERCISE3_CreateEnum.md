# Exercise 3 — Use an enum for safety

Goal: Add a new enum `Category` and a `Category` property to `Product` to classify products.

Steps:
1. Create a new enum in `Enums.cs` or a new file `Category.cs`:

```csharp
public enum Category
{
    Electronics,
    Books,
    Clothing,
    Accessories
}
```

2. Add a property to `Product`:

```csharp
public Category Category { get; set; } = Category.Electronics;
```

3. In `Program.cs`, set `keyboard.Category = Category.Electronics;` and print it.

Hints:
- Enums prevent invalid string values and make code easier to read.

Verify:
- Run the app and confirm the category prints as `Electronics`.
