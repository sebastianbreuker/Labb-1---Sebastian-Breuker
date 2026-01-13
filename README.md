# Labb 1

En enkel konsolapp som läser in en sträng och letar efter tal (siffror) som börjar och slutar med samma siffra. När ett sådant tal hittas skrivs hela inmatningen ut, där just den hittade delen markeras i rött. Alla hittade tal summeras och totalsumman skrivs ut.

## Vad programmet gör

1. Programmet ber dig skriva in en valfri textrad.
2. Den går igenom texten och letar efter sekvenser som:
   - börjar på en siffra,
   - består av en sammanhängande följd av siffror,
   - och där den **första** och **sista** siffran i följden är samma.
3. För varje träff:
   - skrivs hela strängen ut,
   - tecknen som ingår i den matchade siffersekvensen färgas **röda**,
   - och talet läggs till i en totalsumma.
4. När hela texten har gåtts igenom skrivs totalsumman ut.

## Exempel

Inmatning:

```
abc1231xyz77q
```

Programmet kan då hitta:

- `1231` (börjar och slutar med `1`)
- `77` (börjar och slutar med `7`)

Och skriver sedan ut:

- den markerade raden för varje hittat tal
- samt:

```
Din totala summa är: 1308
```

## Köra projektet

Kör via .NET CLI i projektmappen:

```bash
dotnet run
```

## Teknik

- .NET 8
- C# 12
- Konsolapp
