using System;


namespace Interfaces
{
    internal class Program
    {

        class Organismo
        {
            public void respirar()
            {
                Console.WriteLine("Respirar");
            }

            public void mover()
            {
                Console.WriteLine("Se mueve");
            }

            public void crecer()
            {
                Console.WriteLine("Puede crecer");
            }
        }

        public interface IAnimales
        {
            //Método
            void multiCelulares();
            void SangreCaliente();

        }
         
        public interface IAnimal : IAnimales
        {
            void correr();
            void viviparo();
        }

        public interface IPajaro : IAnimales
        {
            //Método
            void volar();
            void oviparo();

        }

        class Perro : Organismo, IAnimal
        {
            public void multiCelulares()
            {
                Console.WriteLine("Estos organismos son MultiCelulares");
            }

            public void SangreCaliente()
            {
                Console.WriteLine("Estos organismos son de sangre caliente");
            }


            public void correr()
            {
                Console.WriteLine("Este organismo es capaz de correr");
            }

            public void viviparo()
            {
                Console.WriteLine("Este organismo es vivíparo");
            }
        }

        class Aguila : Organismo, IPajaro
        {
           public void multiCelulares()
            {
                Console.WriteLine("Este organismo es multicelular");
            }

            public void SangreCaliente()
            {
                Console.WriteLine("Este organismo es de sangre caliente");
            }

            public void volar()
            {

            }
            public void oviparo()
            {
                Console.WriteLine("Este orgnismo es ovíparo");
            }
        }



        static void Main(string[] args)
        {
            //Instancia
            Perro perros = new Perro();
            Console.WriteLine("Este son las caracteristicas de los perros");
            perros.respirar();
            perros.mover();
            perros.crecer();
            perros.multiCelulares();
            perros.SangreCaliente();
            perros.correr();
            perros.viviparo();

            Aguila aguilas = new Aguila();
            Console.WriteLine("Estas son las caracteristicas de las Ágilas:");
            aguilas.respirar();
            aguilas.mover();
            aguilas.crecer();
            aguilas.multiCelulares();
            aguilas.SangreCaliente();
            aguilas.volar();
            aguilas.oviparo();

            Console.ReadKey();

           
        }
    }
}
