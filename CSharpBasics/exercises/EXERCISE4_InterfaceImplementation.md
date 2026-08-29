# Exercise 4 — Implement an interface

Goal: Add a repository implementation that persists products to a file (simple text file).

Steps:
1. Open `CSharpBasics/Interfaces.cs` and review `IProductRepository` and `InMemoryProductRepository`.
2. Create a new class `FileProductRepository` in the same file or a new file `FileProductRepository.cs`.
3. Implement `GetById` and `Save` to write/read lines to `products.txt` in the project folder. Keep format simple: `id|name|price`.

Hints:
- Use `File.AppendAllLines` or `File.WriteAllText` for simple persistence.
- Parse strings using `string.Split('|')` to reconstruct `Product` objects.

Verify:
- Replace `IProductRepository repo = new InMemoryProductRepository();` in `Program.cs` with `new FileProductRepository()` and run the app.
- Confirm `products.txt` is created and contains the saved product line.

Safety note: this is just a simple exercise — real apps use structured formats (JSON) and error handling.
