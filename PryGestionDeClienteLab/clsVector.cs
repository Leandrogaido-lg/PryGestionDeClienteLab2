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

        static public void CargaDatosPrueba()    

        {
            clsVector.Clientes[IND].Codigo = 10;
            clsVector.Clientes[IND].Usuario = "Guada";
            clsVector.Clientes[IND].Deuda = 5000;
            clsVector.Clientes[IND].Limite = 10000;
            clsVector.IND++;

            clsVector.Clientes[IND].Codigo = 20;
            clsVector.Clientes[IND].Usuario = "marta";
            clsVector.Clientes[IND].Deuda = 2000;
            clsVector.Clientes[IND].Limite = 10000;
            clsVector.IND++;

            clsVector.Clientes[IND].Codigo = 30;
            clsVector.Clientes[IND].Usuario = "Sofia";
            clsVector.Clientes[IND].Deuda = 4000;
            clsVector.Clientes[IND].Limite = 10000;
            clsVector.IND++;
            clsVector.Clientes[IND].Codigo = 5;
            clsVector.Clientes[IND].Usuario = "Maria";
            clsVector.Clientes[IND].Deuda = 7000;
            clsVector.Clientes[IND].Limite = 100000;
            clsVector.IND++;
        }

        static public RegCli[] Clientes = new RegCli[10];

        static public Int32 IND = 0;

        static public void OrdenarCodigoAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Codigo > Clientes[i + 1].Codigo)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
       


        static public void OrdenarCodigoDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarUsuarioAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) > 0)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarUsuarioDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) < 0)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarDeudaAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarDeudaDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Deuda < Clientes[i + 1].Deuda)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarLimiteAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Limite > Clientes[i + 1].Limite)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarLimiteDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli aux;


            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {



                    if (Clientes[i].Limite < Clientes[i + 1].Limite)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

    }
}
