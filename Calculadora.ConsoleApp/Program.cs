    using System;
    using System.Data.Common;

    namespace Calculadora.ConsoleApp;


    // Requisito 01

    // Requisito 02

    // Requisito 03

    // Requisito 04

    // Requisito 05

    // Requisito 06

    //  Requisito 07

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

            // || = comparação não obrigatória (só precisa ser verdadeiro)
            if (operação == "S" || operação == "s")
                break;

            // && comparação obrigatória 

            if (operação != "1" && operação != "2" && operação != "3" && operação != "4" && operação != "S" && operação != "s")
            {
                Console.WriteLine("Operação invalida, tente novamente...");
                Console.ReadLine();

                continue;
            }

               

            Console.WriteLine("Digite o primeiro numero:");

            //Declaração
            string primeiroNumeroString = "";



            // Atribuição - Passar para a variavel
            primeiroNumeroString = Console.ReadLine();

            double primeiroNumero = Convert.ToDouble(primeiroNumeroString);


            Console.WriteLine(" Digite o segundo Numero:");


            string segundoNumeroString = Console.ReadLine();

            double segundoNumero = Convert.ToDouble(segundoNumeroString);

            double resultado = 0;

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
                //checar se o segundo número é 0
                while (segundoNumero == 0)
                {
                    //caso seja 0, pedir para o usuario digitar de novo
                        Console.WriteLine("segundo número não pode ser Zero, tente novemente");

                        Console.ReadLine();

                        Console.WriteLine("Digite o segundo número novamente: ");

                         segundoNumero = Convert.ToInt32(Console.ReadLine());
                }


                    //caso não, dividir

                     resultado = primeiroNumero / segundoNumero;
            }


            Console.WriteLine(" O resultado é: " + resultado);



            Console.ReadLine();


      
        }

        }

        }
            
            
    





       