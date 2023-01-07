int[] a = new int[10];
Random r = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = r.Next(0, 15);
    Console.Write(a[i]);
    Console.Write(" ");
}
int mo = a[0];
int me = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 0 && me < a[i])
    {
        me = a[i];
    }
    if (a[i] % 2 == 1 && mo < a[i])
    {
        mo = a[i];
    }

}
Console.WriteLine("\n" + me);
Console.WriteLine(mo);
for (int i = 0; i < a.Length; i++)
{
    if (me > mo && a[i] % 2 == 1)
    {
        a[i] = 0;
    }
    else if (mo > me && a[i] % 2 == 0) a[i] = 0;
    Console.Write(a[i]  );
    Console.Write(" ");
}