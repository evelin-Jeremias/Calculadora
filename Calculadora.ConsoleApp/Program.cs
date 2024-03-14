    using System;
    using System.Data.Common;

    namespace Calculadora.ConsoleApp;


    // Requisito 01

    // Requisito 02

    // Requisito 03

    // Requisito 04

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
            Console.WriteLine(" Calculadora 2024");

            Console.WriteLine("Digite 1 para Adicionar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para Dividir");
            Console.WriteLine("Digite 5 para para 0");
            Console.WriteLine("Digite M para acessar Menu");
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



            Console.WriteLine(" Digite o terceiro Numero:");


            string terceiroNumeroString = Console.ReadLine();

            int terceiroNumero = Convert.ToInt32(terceiroNumeroString);

            

            if (operação == "2")
            {
                resultado = segundoNumero + terceiroNumero;
            }
            else if (operação == "3")
            {
                resultado = segundoNumero + terceiroNumero; 


            }



            Console.WriteLine(" Digite o Quarto Numero:");


            string quartoNumeroString = Console.ReadLine();

            int quartoNumero = Convert.ToInt32(quartoNumeroString);



            if (operação == "3")
            {
                resultado = terceiroNumero + quartoNumero;
            }
            else if (operação == "4")
            {
                resultado = terceiroNumero + quartoNumero;


            }

            Console.WriteLine(" O resultado é: " + resultado);



            Console.ReadLine();


      
        }

        }

        }
            
            
    





       