
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class HelloWorld
{
    static List<string> nomes = new List<string>();
    static int quantidade = nomes.Count;
    public static void Main(string[] args)
    {
        string option;
        int posicao;
        string nome2;
    
            

            Console.WriteLine("Cadastro de usuários:");
            Console.WriteLine("1- Cadastrar\n2- Buscar\n3- Deletar\n4- Atualizar\n5- Listar");
            Console.WriteLine("Escolha uma opção:");
            option = Console.ReadLine();

            if (option == "1") {

                Console.WriteLine("Qual nome deseja cadastrar?");
                nomes.Add(Console.ReadLine());
                Console.WriteLine("\n------------ Cadastro realizado com sucesso.\n\n");
                Main(null);
                
                return;

            }

            if (option == "2")
            {
                 if (nomes.Count == 0)
                {   

                    Console.WriteLine("A lista esta vazia.");
                    Console.ReadLine();
                    Console.Clear();
                    Main(null);
                    
                    return;
                }

                Console.WriteLine("Digite a posição que quer buscar");
                posicao = int.Parse(Console.ReadLine());
                
                if (posicao <= nomes.Count) {
                Console.WriteLine($"Nome: {nomes[posicao]}");
                Console.ReadLine();
                Console.Clear();
                Main(null);
               
                return;
                }else{
                Console.WriteLine("Usuario nao localizado.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                    
                return;
            }

            }

            if (option == "3") {
                Console.WriteLine("Digite a posição que quer deletar");
                posicao = int.Parse(Console.ReadLine());
                
                if (posicao <= nomes.Count) {
                nomes.RemoveAt(posicao);
                Console.WriteLine($"Usuario deletado com sucesso.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
               
                return;
                }else{
                Console.WriteLine("Usuario nao localizado.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                    
                return;
                
            }
            }
            
            if (option == "4") {
                Console.WriteLine("Digite a posição do nome que deseja alterar");
                posicao = int.Parse(Console.ReadLine());
                
                if (posicao <= nomes.Count) {
                Console.WriteLine($"Digite o novo nome: ");
                nome2 = Console.ReadLine();
                nomes[posicao] = nome2;
                Console.WriteLine("Alterado com sucesso.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
               
                return;
                }else{
                Console.WriteLine("------ Usuario nao localizado --------");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                    
                return;
                
            }
                
            }
            
            if (option == "5") {
                Console.WriteLine($"Nomes cadastrados no sistema:\n");
                    int contador = 0;
                    while (contador <= nomes.Count) {
                        string nome = nomes[contador];
                        
                        Console.WriteLine($"{contador} - {nome}");
                        contador++;                        

                    }

                    Console.WriteLine("-------Fim---------");
                    Console.ReadLine();
                    Console.Clear();
                    Main(null);
                    
                    return;
                
            }

            Console.ReadKey();
    }
}
