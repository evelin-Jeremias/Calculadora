    using System;
    using System.Data.Common;

    namespace Calculadora.ConsoleApp;


    // Requisito 01

    // Requisito 02

    // Requisito 03

    // Requisito 04

    // Requisito 05

    internal class Program
        {
    static void Main(string[] args)

    {

        // Laços de Repetição / loops


        //true ou false




        // faça 
        while (true)
        {

            Console.Clear();
            Console.WriteLine(" Calculadora 2024\n");


            Console.WriteLine("Digite 1 para Adicionar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para dividir");
           
            Console.WriteLine("Digite S para sair");

            string operação = Console.ReadLine();

            if (operação == "S")
                break;


            Console.WriteLine("Digite o primeiro numero:");

            //Declaração
            string primeiroNumeroString = "";



            // Atribuição - Passar para a variavel
            primeiroNumeroString = Console.ReadLine();

            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);


            Console.WriteLine(" Digite o segundo Numero:");


            string segundoNumeroString = Console.ReadLine();

            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = 0;

            if (operação == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else if (operação == "2")
            {
                resultado = primeiroNumero + segundoNumero;


            }

            
            else if (operação == "3")
            {
                resultado = primeiroNumero * segundoNumero;


            }

            else if(operação == "4")
            {
                resultado = primeiroNumero / segundoNumero;
            }


            Console.WriteLine(" O resultado é: " + resultado);



            Console.ReadLine();


      
        }

        }

        }
            
            
    





       