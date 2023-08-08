using System;

namespace InSystem
{
    class SistemaIn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            string idadeStr = Console.ReadLine();
            int idade = int.Parse(idadeStr);

            Console.WriteLine("Verificando...");
            Console.Clear();

            if (idade < 18)
            {
                Console.WriteLine("Não Autorizado!");
                Console.Clear();
            }
            if (idade >= 18 && idade <= 100)
            {
                Console.WriteLine("Autorizado!");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Informações Inválidas!");
                Console.Clear();
            }

            if (idade >= 18 && idade <= 100)
            {
                IntwoSystem.Equacoes.MostrarMensagem();
            }
            else {
                Console.WriteLine("Acesso restrito!");
                    }
        }
    }
}
