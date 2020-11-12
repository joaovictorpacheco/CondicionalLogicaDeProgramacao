using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o código do nosso programa
            //C# é uma linguagem case sensitive

            //Declarar variáveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;

            //entrada de dados
            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //processamento
            media = (nota1+nota2+nota3)/3;

            //Exibir o resultado 
            if(media>5){
                //valor verdadeiro
                Console.WriteLine("O aluno "+nomeCompleto+" está APROVADO com a média de: "+media);
            }else{
                Console.WriteLine("O aluno "+nomeCompleto+" está REPROVADO com a média de: "+media);
            }

        }
    }
}
