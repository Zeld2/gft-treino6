using static exer1.Numeros;

Console.WriteLine("Valor inicial (maior que 0):");

var inicial = Int32.Parse(Console.ReadLine());

Console.WriteLine("Valor final (maior que o final):");

var final = Int32.Parse(Console.ReadLine());

var resultado = Impares(inicial, final);

System.Console.WriteLine(resultado);