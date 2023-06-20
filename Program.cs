using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv09EstoqueProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> {"pepsi ","fanta" };

            Console.WriteLine("Bem-vindo ao Wendell Store");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                var resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("digite o nome do produto:");
                    var produto = Console.ReadLine();
                    produto = produto.ToLowerInvariant();
                    if (produtos.Contains(produto) )
                    {
                        Console.WriteLine("este item ja existe....");

                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("produto adicionado com sucesso!!");
                           
                    }
                }
                else
                {
                    

                    var texto = "";
                    var contador = 0;
                    while (contador < produtos.Count )
                    {
                        var palavra = produtos[contador];
                        var primeira = palavra.Substring(0, 1);
                        primeira = primeira.ToUpper();
                        string segunda = palavra.Substring(1, texto.Length);
                        string palavrac = primeira + segunda;
                        texto += produtos[contador] + ", ";
                        contador++;
                        
                    }

                     texto = texto.Substring(0, texto.Length- 2);
                    Console.WriteLine(texto);

                }
            }

        }
    }
}
