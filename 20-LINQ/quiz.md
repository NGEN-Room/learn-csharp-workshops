# Quiz – LINQ

1. What does `.Where()` do in a LINQ query?
2. What’s the difference between method syntax and query syntax?
3. Write a LINQ expression that selects numbers greater than 10 from a list.
4. What does `FirstOrDefault()` return if nothing matches?
5. What does this print?
```csharp
var names = new List<string> { "Aroha", "Piha", "Mana" };
var result = names.Where(n => n.StartsWith("P"));
Console.WriteLine(result.Count());
```
