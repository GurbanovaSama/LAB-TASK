using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMethod
{
   // Ele bir method yazin ki bu method gonderilen string text daxilinde verilmis
   // oldugumuz string ifadeni axtarib tapsin ve ekrana bu barede melumat versin.
   // Melumat dedikde ise bu ifadenin burda yer alib-almamasi melumati nezerded tutulur.
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is programming";
            string word = "programming";
            Content(text, word);
        }
        public static void Content(string text, string word)
        {
           if ( text.Contains(word))
            {
                Console.WriteLine("bu ifade burada yer alib");
            }
           else
            {
                Console.WriteLine("bu ifade burada yer almayib");
            }



           
        }
    }
}
