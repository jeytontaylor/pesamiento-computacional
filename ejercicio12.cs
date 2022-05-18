
using system;
using system.collection.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace consoleApp1
{
    internal class program
    {
        static void Main(string{}  args)
        {
            double A, B, C;
            console.Write("ingrese el valor del cateto A:");
            A=double.parse(console.ReadLine());


             console.Write("ingrese el valor de la hipotenusa c:");
             C= double.parse(console.ReadLine());


            B= Math.pow(c, 2) - Math.pow(A, 2);


            Console.Write("El valor del cateto B es : "+ B );

            Console.Readkey(); 