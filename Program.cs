//Jumara  Andrade Amaro Fernandes
//a43691
using System;
namespace Trabalho_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            AlugAuto a = new AlugAuto(20);
            int opMenu = 1;
            while(opMenu!=0)
            {
               Console.WriteLine("Bem-vindo!");
               Console.WriteLine("Escolha uma das seguintes opções");
               Console.WriteLine("1-Adicionar Viatura de Luxo");
               Console.WriteLine("2-Adicinar Viatura de Utilitario");
               Console.WriteLine("3-Registar aluguer");
               Console.WriteLine("4-Listar Viaturas");
               Console.WriteLine("5-Listar Clientes");
               Console.WriteLine("6-Definir Preço");
               Console.WriteLine("0-Sair");
               
               opMenu =int.Parse(Console.ReadLine());


              if (opMenu==0)
            {
                break;
            }
           else if (opMenu==1)
            {
                a.AdicinonarViaturaLuxo(12,"AB12");
            }
            else if (opMenu==2)
            {
                a.AdicinonarViaturaUtilitario("MB15");
            }
            else if (opMenu==3)
            {
                a.RegistarAluguer("PS56","BBBB",15);
            }
            else if (opMenu==4)
            {
                a.listarviaturas();
            }
            else if (opMenu==5)
            {
                a.listarclientes();
            }
            else  if (opMenu == 6)
            {
                a.DefinirPreco(45);
            }
            else
            {
                Console.WriteLine("Opcão Invalida, tente novamente");
            }
            }


           /* menu("adicionar cliente", "adicionar viartura", "registrar aluguer", "Listar Viaturas", "Listar Clientes");
            Console.WriteLine("Sua opção: ");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Matricula: ");
                string matricula = Console.ReadLine();
                a.AdicinonarViaturaLuxo(10, matricula);
            }*/
        }
        /*static void menu(params string[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"{i+1} - {lista[i]}");
            }
        }*/
    }
}