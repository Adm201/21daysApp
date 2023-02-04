
Console.WriteLine("Podaj liczbe: ");


int[] charQuantity = new int[10];

for(int i = 0; i < 10; i++)
{
    charQuantity[i] = 0;
}

string numberString = Console.ReadLine();
char[] letter = numberString.ToCharArray();

for(int i = 0; i < numberString.Length; i++)
{
    for(int j = 0; j < 10; j++)
    {
        string jString = j.ToString();
        if (letter[i] == jString[0]) 
        { 
            charQuantity[j]++; 
        }
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cyfra " + i + " występuje " + charQuantity[i] + " razy.\n");
}