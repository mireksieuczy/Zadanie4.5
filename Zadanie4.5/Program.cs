int[] tab1 = { 1, 2, 3, 4, 5, 6 };
int[] tab2 = new int[tab1.Length];

Array.Copy(tab1, 0, tab2, 1, 5);
Array.Copy(tab1, 5, tab2, 0, 1);
for (int i = 0; i < tab1.Length; i++)
{
    Console.WriteLine(tab1[i]);
}
Console.WriteLine();
foreach (int x in tab2)
    Console.WriteLine(x);

Console.ReadKey();