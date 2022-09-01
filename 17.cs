using System;

class Program 
{
    static void Main(string[] args)
    {
        string nome;
        double salario, anos;

        Console.WriteLine("Qual é seu nome?");
        Console.ReadLine();

        Console.WriteLine("Há quantos anos você trabalha na empresa?");
        anos = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual é seu salário?");
        salario = double.Parse(Console.ReadLine());
        
        if (anos <= 3 && anos < 4){
            Console.WriteLine("Seu salário aumentará para: R$" + (salario * 0.03));
        } 
        if (anos <= 10 && anos < 11  ){
            Console.WriteLine("Seu salário aumentará para: R$" + (salario * 0.125));
        } else {
            Console.WriteLine("Seu salário aumentará para: R$" + (salario * 0.20));
        }
            
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();
    }
}