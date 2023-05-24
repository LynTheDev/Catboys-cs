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

CatboyImage image = await CatboysAPI.GetImage();
Console.WriteLine($"Got \"{image.URL}\" from \"${image.Artist}\".");
```

```
Got "https://cdn.catboys.com/images/image_184.jpg" from "alioathereal".
```
