using System;
using System.Collections.Generic;
namespace Trabalho_de_programação
{
    class Luxo:Viatura
    {
       decimal taxaLuxo;
    
     public  Luxo( decimal taxaLuxo, string matricula) : base(matricula)
     {
         this.taxaLuxo = taxaLuxo;
     }
}
}