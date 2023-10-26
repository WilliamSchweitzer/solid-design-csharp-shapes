# Object Oriented .NET6.0 Project for multidimensional shapes 

**I am currently searching for software development or software engineering job opportunities.**
[LinkedIn](https://www.linkedin.com/in/william-schweitzer/)

## Description
```
Object oreiented SOLID principles design project using .NET6.0, C#, Linux (Debian-x64), terminal, GitHub CLI, and VIM. In order to demonstrate competency in the aforementioned areas. The project is inspired by a Digital Ocean article where I define various 2D and 3D shapes as objects.
 ```

```stl
solid cube_corner
  facet normal 0.0 -3.0 0.0
    outer loop
      vertex 0.0 0.0 0.0
      vertex 3.0 0.0 0.0
      vertex 0.0 0.0 3.0
    endloop
  endfacet
  facet normal 0.0 0.0 -3.0
    outer loop
      vertex 0.0 0.0 0.0
      vertex 0.0 3.0 0.0
      vertex 3.0 0.0 0.0
    endloop
  endfacet
  facet normal -3.0 0.0 0.0
    outer loop
      vertex 0.0 0.0 0.0
      vertex 0.0 0.0 3.0
      vertex 0.0 3.0 0.0
    endloop
  endfacet
  facet normal 1.731 1.731 1.731
    outer loop
      vertex 3.0 0.0 0.0
      vertex 0.0 3.0 0.0
      vertex 0.0 0.0 3.0
    endloop
  endfacet
endsolid
```

### Notes
- Publish .Net repositorys via. shell command `dotnet publish -r linux-x64 --self-contained false`

#### Sources
1. [Digital Ocean SOLID Article](https://www.digitalocean.com/community/conceptual-articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design)
2. [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
3. [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
4. [GitHub Shape Visualization](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/creating-diagrams)
