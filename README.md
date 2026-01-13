# Labb 1

Detta är min första labb i min utbildning .NET Utvecklare. (Efter cirka 3 veckor in i utbildningen)
Det är en konsolapp som ska skriva ut och känna av tal i en följd efter det jag beskriver nedan.
## Vad programmet gör

1. Programmet ber dig skriva in en valfri textrad. (Exempelrad: 29535123p48723487597645723645
2. Den går igenom texten och letar efter sekvenser som:
   - börjar på en siffra,
   - består av en sammanhängande följd av siffror,
   - och där den **första** och **sista** siffran i följden är samma.
3. För varje träff:
   - skrivs hela strängen ut,
   - tecknen som ingår i den matchade siffersekvensen färgas **röda**,
   - och talet läggs till i en totalsumma.
4. När hela texten har gåtts igenom skrivs totalsumman ut på alla rader som blivit markerade.

## Exempel

Inmatning: 29535123p48723487597645723645

```
```

Programmet kör då:

- `2953512` (börjar och slutar med `2`)
- `535` (börjar och slutar med `7`)
- Osv osv

Och skriver sedan ut:

- den markerade raden för varje hittat tal
- samt:

```
Din totala summa är: 5836428677242
```

## Exempel

![Exempelutskrift](docs/image_labb1.png)

## Köra projektet

Kör via Visual Studio

```bash
dotnet run
```

## Teknik

- .NET 8
- C# 12
- Konsolapp
