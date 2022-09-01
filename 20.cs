using System;

class Program 
{
    static void Main(string[] args)
    {
        double peso, altura;
        // double imc;
        //imc == peso / (altura * altura);

        Console.WriteLine("Qual é sua altura?");
        altura = double.Parse(Console.ReadLine());


        Console.WriteLine("Qual é seu peso?");
        peso = double.Parse(Console.ReadLine());

    

        Console.WriteLine("Seu imc é de " + peso / (altura * altura));
        
        if ((altura * altura) / peso < 18.5){
            Console.WriteLine("Abaixo do peso");
        }  
        if ( (altura * altura) / peso == 18.5 && (altura * altura) / peso<= 25){
            Console.WriteLine("Peso ideal");
        } 
        if ((altura * altura) / peso   > 25 && peso / (altura * altura)<= 30){
            Console.WriteLine("Sobrepeso");
        } 
        if ((altura * altura) / peso   > 30 && (altura * altura) / peso <= 40){
            Console.WriteLine("Obesidade");
        }
        if ((altura * altura) / peso > 40){
            Console.WriteLine("Obesidade mórbida");
        }    
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

        //não consegui mais :c
    }
 }