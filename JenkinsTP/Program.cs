using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace JenkinsTP
{
    public static class Program
    {
        static void Main()
        {
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void StringCopyCpy()
        {
            String couleur = null;

            if(2 == 2)
            {
                 couleur = "rouge";
            }

            switch (couleur)

            {

                case "rouge":

                    Console.WriteLine("Tu aimes la couleur du sang");

                    break;


                case "vert":

                    Console.WriteLine("Tu aimes la nature");

                    break;


                case "bleu":

                    Console.WriteLine("Tu aimes la couleur du ciel");

                    break;


                case "blanc":

                    Console.WriteLine("Tu aimes la purete");

                    break;


                default:

                    Console.WriteLine("Je n'ai aucune commentaire a faire");

                    break;

            }


        }

        public static void StringCopyCpy2()
        {
            String couleur = null;

            if (2 == 2)
            {
                couleur = "rouge";
            }

            switch (couleur)

            {

                case "rouge":

                    Console.WriteLine("Tu aimes la couleur du sang");

                    break;


                case "vert":

                    Console.WriteLine("Tu aimes la nature");

                    break;


                case "bleu":

                    Console.WriteLine("Tu aimes la couleur du ciel");

                    break;


                case "blanc":

                    Console.WriteLine("Tu aimes la purete");

                    break;


                default:

                    Console.WriteLine("Je n'ai aucune commentaire a faire");

                    break;

            }


        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }
    }
}
