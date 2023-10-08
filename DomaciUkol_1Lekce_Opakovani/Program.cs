// 1.Vytvoř pole typu int s těmito hodnotami {3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4,-2}. Pro kontrolu si obsah pole vypiš.

// práce přes for
int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };

for (int i = 0; i < pole.Length; i++)
{
    Console.Write($"{pole[i]} ");
}
Console.ReadLine();

// práce přes foreach
int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };

foreach (int i in pole)
{
    Console.Write($"{i} ");
}
Console.ReadLine();


// 2. Vyhledej záporná čísla a změň je na kladné číslo, zároveň vyhledej nuly a ke každé přičti hodnotu jejího indexu. Výsledné pole si vypiš.

// práce přes for
int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };

for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] != Math.Abs(pole[i]))
    {
        pole[i] = Math.Abs(pole[i]);
    }
    else if (pole[i] == 0)
    {
        pole[i] = pole[i] + i;
    }
}
for (int i = 0; i < pole.Length; i++)
{
    Console.Write($"{pole[i]} ");
}
Console.ReadLine();

// práce přes foreach
int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };

foreach (int i in pole)
{
    int indexZapor = 0;
    int indexNula = 0;

    if (i != Math.Abs(i))
    {
        indexZapor = Array.IndexOf(pole, i);
        pole[indexZapor] = Math.Abs(i);
    }
    else if (i == 0)
    {
        indexNula = Array.IndexOf(pole, i);
        pole[indexNula] = i + indexNula;
    }
}
foreach (int i in pole)
{
    Console.Write($"{i} ");
}
Console.ReadLine();


// 3. Vyhledej největší číslo v poli a vypiš ho.

// práce přes for
int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };
int porovnani = pole[0];

for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] > porovnani)
    {
        porovnani = pole[i];
    }
}
Console.WriteLine($"Největší číslo v poli je: {porovnani}");
Console.ReadLine();

// práce přes foreach
int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };
int porovnani = pole[0];

foreach (int i in pole)
{
    if (i > porovnani)
    {
        porovnani = i;
    }
}
Console.WriteLine($"Největší číslo v poli je: {porovnani}");
Console.ReadLine();


// 4. Seřaď prvky v poli od nejmenšího po největší. Můžeš například využít toho, že už umíš najít největší číslo v poli.
// Prosím, nepoužívej už hotovou funkci na sortování, jde o to, aby sis takovou funkci zkusila napsat sama.

int[] pole = new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };
int docasnaHodnota = 0;

for (int i = 0; i < pole.Length; i++)
{
    for (int j = i + 1; j < pole.Length; j++)
    {
        if (pole[i] > pole[j])
        {
            docasnaHodnota = pole[i];
            pole[i] = pole[j];
            pole[j] = docasnaHodnota;
        }
    }
}
for (int i = 0; i < pole.Length; i++)
{
    Console.Write($"{pole[i]} ");
}
Console.ReadLine();
