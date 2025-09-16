

Console.Write("Skriv in något: ");
string input = Console.ReadLine();
Console.WriteLine();
long total = 0;

for (int i = 0; i < input.Length; i++)
{
    if (!char.IsDigit(input[i])) continue;
    char bokstav = input[i];

	for (int j = i + 1; j < input.Length; j++)
	{
        string tal = input.Substring(i, j - i + 1);
        if (!char.IsDigit(input[j])) break;
        if (input[j] != bokstav) continue;
            
            for (int k = 0; k < input.Length; k++)
            {
                 
                if (k >= i && k <= j)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.Write(input[k]);

            }
            Console.WriteLine();
        
        total += long.Parse(tal);
        break;
	}
    
}

Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"Din totala summa är: {total}");
