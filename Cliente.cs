using System;
using System.Collections.Generic;
namespace Trabalho_de_programação
{
    class Cliente
    {
        string nome;
        string carta;
        List<Aluguer> listaaluguer;

      public  Cliente ( string nome, string carta)
      {
          this.nome = nome;
          this.carta = carta;
          this.listaaluguer = new  List<Aluguer>();

      }
       public void AdicionarAluguer(Aluguer aluguer)
      {
         listaaluguer.Add(aluguer);

      }
      public void MostraCliente()
      {
         Console.WriteLine("Nome: "+this.nome);
         Console.WriteLine("Carta: "+this.carta);
    
      }
      public string getcli()
      {
          return this.carta;
      }
    public void MostraAluguer()
    {
      foreach (Aluguer item in listaaluguer)
      {
          item.Mostar();
      }
    }
    }
}