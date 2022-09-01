using System;

class Program 
{
    static void Main(string[] args)
    {
        double valor, salario, anos;

        Console.WriteLine("Qual é o valor do imóvel?");
        valor = double.Parse(Console.ReadLine());


        Console.WriteLine("em quantos anos você pretende pagar?");
        anos = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual é seu salário?");
        salario = double.Parse(Console.ReadLine());
        
        if (salario * 0.30 < valor / anos * 12){
            Console.WriteLine("Empréstimo negado");
        }  else {
            Console.WriteLine("Empréstimo aprovado");
        }
            
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();
    }
}