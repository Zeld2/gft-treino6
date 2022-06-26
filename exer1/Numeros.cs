namespace exer1
{
    public static class Numeros
    {
       public static string Impares(int inicial, int final)
       {
        List<int> impares = new List<int>();
        while (inicial<= final)
        {
            if (!(inicial % 2 == 0)) impares.Add(inicial);
            inicial ++; 
        }
        return String.Join(" ", impares);
       } 

    }
}