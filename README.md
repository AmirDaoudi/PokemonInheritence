# Pokemon Inheritance

A console Pokemon battle game from a 9th-grade C# class (March 2024). The assignment was to practice inheritance and abstract classes: one abstract `Pokemon` base class, then seven Pokemon that each override their own moves.

## How it plays

1. Enter your name. A random wild Pokemon appears.
2. Choose to fight, then pick your Pokemon by name from the list.
3. Each turn you choose one of three moves: two attacks that trade your own health for damage, or a heal.
4. The opponent answers with a random move until one side hits zero health.

## Structure

- `Pokemon.cs`: abstract base class with type, health, damage stats, and three abstract moves
- `Charizard.cs`, `Onix.cs`, `Jynx.cs`, `Exeggutor.cs`, `DewGong.cs`, `PrimeApe.cs`, `Toedschool.cs`: concrete subclasses
- `Program.cs`: encounter, selection menu, battle loop, and win check

## Run it

```bash
dotnet run --project PokemonInheritence
```

Requires the .NET SDK.
