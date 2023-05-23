# Catboys.cs

A C# package that uses the catboys API.

# Install

```powershell
dotnet add package CatboysCS
```

# Endpoints you can use
- img
- baka
- 8ball
- dice

# Example

```cs
using Catboys;

var result = CatboysAPI.Img();
foreach (var item in result)
    Console.WriteLine($"{item.Key}: {item.Value}");
```

```bash
url: https://cdn.catboys.com/images/image_184.jpg
artist: alioathereal
```