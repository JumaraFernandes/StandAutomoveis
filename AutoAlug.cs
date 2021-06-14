using System;
using System.Collections.Generic;

namespace Trabalho_de_programação
{

    class AlugAuto
    {
        List<Cliente> listacliente;
        List<Viatura> listaviatura;

        public AlugAuto(decimal precoDias)
        {
            this.listacliente = new List<Cliente>();
            this.listaviatura = new List<Viatura>();
            DefinirPreco(precoDias);
        }
        public void DefinirPreco(decimal precoDias)
        {
              Viatura v = new Luxo(0,"");
              v.DefinirPreco(precoDias);
        }
        public bool AdicinonarViaturaLuxo(decimal taxaluxo, string matricula)
        {
              
            Viatura vl = EncontrarViatura( matricula);
           
            if (vl == null)
            {
              vl = new Luxo(taxaluxo,matricula); 
               listaviatura.Add(vl);
               return true;
            }
            return false;
           
          }
        public bool AdicinonarViaturaUtilitario(string matricula)
        {
           Viatura vu =  EncontrarViatura(matricula);
           if (vu == null)
           {
                vu = new Utilitario(matricula);
               listaviatura.Add(vu);
               return true;
           }
           return false;
           
            
        }
        public Viatura EncontrarViatura(string matricula)
        {

            foreach (Viatura item in listaviatura)
            {
                if (item.getMatricula() == matricula)
                    return item;
            }
            return null;
        }
        public Cliente EncontrarCliente(string carta)
        {

            foreach (Cliente item in listacliente)
            {
                if (item.getcli() == carta)
                    return item;
            }
            return null;

        }
        public void listarviaturas()
        {
            foreach (Viatura item in listaviatura)
            {
                item.MostarViatura();
            }
        }
        public void listarclientes()
        {
            foreach (Cliente item in listacliente)
            {
                item.MostraCliente();
            }
        }

        public int RegistarAluguer(string carta, string matricula, int dias)
        {
            Cliente cliente = EncontrarCliente(carta);
            if (cliente == null)
            {
                Console.WriteLine("cliente não existe");
                return -1;
            }
            Viatura viatura = EncontrarViatura(matricula);
            if (viatura == null)
            {
                Console.WriteLine("viatura não existe");
                return  -1;
            }

            Aluguer aluguer1 = new Aluguer(dias,viatura.getva(),cliente,viatura);
             cliente.AdicionarAluguer(aluguer1);
             viatura.AdicionarAluguer(aluguer1);
             return aluguer1.getId();
          
        }

        //total de todas as viaturas
        public  void MostraTotal()
        {
            decimal total = 0;
           foreach (Viatura item in listaviatura)
           {
               total+=item.TotalFaturado();
           }
           Console.WriteLine($"Tota Faturado {total}");

        }
         //total por viaturas
        public  void MostraTotalViatura(string matricula)
        {         decimal total = 0;
            foreach (Viatura item in listaviatura)
            {
                if (matricula == item.getMatricula())
                {
                    total+=item.TotalFaturado();
                }
            }
        }
       public  void MostraAluguerlViatura(string matricula)
        {
           Viatura viatura = EncontrarViatura(matricula);
           if (viatura == null)
           {
               return;
           }
           viatura.MostraAluguer();
        }
        public  void MostraAluguerCliente(string carta)
        {
           Cliente cliente = EncontrarCliente(carta);
           if (cliente == null)
           {
               return;
           }
           cliente.MostraAluguer();
           
        }

    }
}
