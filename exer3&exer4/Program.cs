using exer3;

var contaCc = new ContaCorrente("123", "Matheus", 200000);

var contaPp = new ContaPoupanca("321", "Matheus", 1000000);

System.Console.WriteLine(contaCc.ToString());
System.Console.WriteLine($"Imposto a ser pago: R${contaCc.calcularImposto()}");

System.Console.WriteLine(contaPp.ToString());
System.Console.WriteLine($"Imposto a ser pago: R${contaPp.calcularImposto()}");
