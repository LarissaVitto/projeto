using System;

class Program 
{
    static void Main(string[]args)
    {
        double a, b, c; 
        

        Console.WriteLine("Escreva a reta 1:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a reta 2:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a reta 3:");
        c = double.Parse(Console.ReadLine());
             
        if ( a < b + c ||  b < a + c || c < a + b){
            Console.WriteLine("È possível formar um triângulo" );

            if (a == b && b == c)
                Console.WriteLine("Seu triângulo é equilátero" );
            if (a == b || a == c || b == c){
                Console.WriteLine("Seu triângulo é isóceles" );
            }else {
                Console.WriteLine("Seu triângulo é escaleno");
            }
        } else {
            Console.WriteLine("Não é possível formar um triângulo");
        }
            
            
            Console.WriteLine("Digite enter para sair...");
            Console.ReadLine();
    }
}