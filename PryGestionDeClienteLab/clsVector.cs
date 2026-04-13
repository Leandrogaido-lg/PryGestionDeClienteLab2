using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryGestionDeClienteLab
{
    internal class clsVector
    {

        public struct RegCli
        {

            public Int32 Codigo;
            public string Usuario;
            public Decimal Deuda;
            public Decimal Limite;


        }

        static public RegCli[] Clientes = new RegCli[10];

        static public Int32 IND = 0;    
    }
}
