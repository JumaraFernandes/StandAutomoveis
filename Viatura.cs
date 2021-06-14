using System;
using System.Collections.Generic;
namespace Trabalho_de_programação
{
       abstract class Viatura
    {
      string matricula;
      static decimal precoDias;
      List<Aluguer> listaaluguer;

      public Viatura(string matricula)
      {
         this.matricula = matricula;
         listaaluguer = new List<Aluguer>();

      }
      public void AdicionarAluguer(Aluguer aluguer)
      {
         listaaluguer.Add(aluguer);

      }
      //o preco vai receber uma variavel que irei passar como parametro
      public void DefinirPreco(decimal preco)
        {
            precoDias = preco;

        }

      public void MostarViatura()
      {
          Console.WriteLine("Matricula : "+this.matricula);
      
      }
      public string getMatricula()
      {
         return this.matricula;
      }
      public decimal getva()
      {
         return precoDias;
      }

      public decimal TotalFaturado()
      {     
          return getva();

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