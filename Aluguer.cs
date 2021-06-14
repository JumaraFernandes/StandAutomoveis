using System;
using System.Collections.Generic;

namespace Trabalho_de_programação
{
    
    class Aluguer
    {
       static int idSeguinte = 1;
       int id;
       int dias;
       decimal valor;
       Viatura viatura;
       Cliente cliente;
      //a variavel id vai receber o valor automaticamente através da variavel estatica idSeguinte;
      public Aluguer(int dias, decimal valor, Cliente cliente, Viatura viatura)
      {
            this.dias = dias;
            this.valor = valor;
            this.id = idSeguinte++;
            this.cliente = cliente;
            
      }
      public decimal getva()
      {
         return this.valor;
      }

      public int getId()
      {
        return id;
      }
      public void Mostar()
      {
         Console.WriteLine($"Dias {dias}");
         Console.WriteLine($"Valor {valor}");
         Console.WriteLine($"ID {id}");
         Console.WriteLine($"Cliente {cliente.getcli()}");
         Console.WriteLine($"Viatura{viatura.getMatricula()}");
      }

   

    }
}