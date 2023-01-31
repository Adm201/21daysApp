

int[] CharQuantity = new int[10];
for(int i=0; i < 10; i++)
{
    CharQuantity[i] = 0;
}

string number = Console.ReadLine();
char[] letter = number.ToArray();

for(int i=0; i<number.Length; i++)
{
    for(int j=0; j<10; j++)
    {
        string j_string = j.ToString();  char[] x = j_string.ToArray();
        if (letter[i] == x[0]) { CharQuantity[j]++; j = 10; }
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cyfra " + i + " występuje " + CharQuantity[i] + " razy.\n");
}