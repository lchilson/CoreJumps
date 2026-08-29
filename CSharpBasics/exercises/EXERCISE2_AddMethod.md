# Exercise 2 — Add a method and call it

Goal: Add a method `ApplyDiscount(decimal percent)` to `Product` that reduces the `Price`.

Steps:
1. Open `CSharpBasics/Product.cs`.
2. Add the method:

```csharp
public void ApplyDiscount(decimal percent)
{
    // percent is 0.10m for 10%
    Price -= Price * percent;
}
```

3. In `Program.cs`, call `keyboard.ApplyDiscount(0.1m);` before printing the total, and observe the changed price.

Hints:
- Methods can change instance state (like `Price`).
- `percent` is a parameter; the value you pass is the argument.

Verify:
- Run the app and observe the new price in output.
