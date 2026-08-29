# Exercise 1 — Add a property

Goal: Add a new public property `Description` to the `Product` class and use it.

Steps:
1. Open `CSharpBasics/Product.cs`.
2. Add a new public auto-property:

```csharp
public string Description { get; set; } = string.Empty;
```

3. In `Program.cs` after creating the `keyboard` product, set `keyboard.Description = "A mechanical keyboard";` and print it:

```csharp
Console.WriteLine($"Description: {keyboard.Description}");
```

Hints:
- Properties are part of the public surface of a class and are written like `public Type Name { get; set; }`.

Verify:
- Run the app:
```powershell
dotnet run --project CSharpBasics
```
- You should see the Description line printed.

Extra (optional):
- Make `Description` read-only (no `set`) and initialize it from the `Product` constructor.
