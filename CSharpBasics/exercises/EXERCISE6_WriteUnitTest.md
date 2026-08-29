# Exercise 6 — Basic unit test (optional)

Goal: Add a tiny test project to assert `CalculateTax` works as expected.

Steps:
1. From the workspace root, run:

```powershell
dotnet new xunit -o CSharpBasics.Tests
dotnet add CSharpBasics.Tests reference CSharpBasics/CSharpBasics.csproj
```

2. Open `CSharpBasics.Tests` and add a test class `ProductTests.cs` with:

```csharp
using Xunit;
using MyStore.Products;

public class ProductTests
{
    [Fact]
    public void CalculateTax_ReturnsExpected()
    {
        var p = new Product("T", 100m);
        var tax = p.CalculateTax(0.06m);
        Assert.Equal(6m, tax);
    }
}
```

3. Run tests:

```powershell
dotnet test CSharpBasics.Tests
```

Hints:
- Tests run separately from the app and are a safety net when you change code.
- This is a good place to add validation once the learner understands objects, methods, and expected behavior.

Verify:
- The test run should pass.

This optional exercise can come after the learner has already seen object state, methods, and constructor behavior. The interface-based and inheritance-based demos remain available as later reference material.
