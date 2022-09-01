using System;

class Program 
{
    static void Main(string[] args)
    {
        int carro;
        double km, dia;

        Console.WriteLine("Seu carro é popular (1) ou de luxo (2)?");
        carro = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantos km vc andou?");
        km = double.Parse(Console.ReadLine());

        Console.WriteLine("Por quantos dias vc alugou o carro?");
        dia = double.Parse(Console.ReadLine());
        
        if (carro == 1 && km > 100){
            Console.WriteLine("O valor a pagar é R$" + ( km - 100 * 0.10 + 90 * dia));
        } 
        if (carro == 1 && km <= 100){
            Console.WriteLine("O valor a pagar é R$" + ( km * 0.20 + 90 * dia));
        } 
        if (carro == 2 && km > 100){
            Console.WriteLine("O valor a pagar é R$" + ( km - 200 * 0.25 + 90 * dia));
        } 
        if (carro == 2 && km <= 100){
            Console.WriteLine("O valor a pagar é R$" + ( km * 0.30 + 90 * dia));
        }
        
            
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();
    }
}