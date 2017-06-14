using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Fiamingo.Florencia._2D
{
    static class Ticketeadora
    {
        private const string FILE_NAME = "C:\\FileTicket.txt";

        static bool ImprimirTicket(this Cajon<Platano> c, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\FileTicket.txt", true))
                {
                    sw.Write("Fecha: ");
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine("Precio total del cajón: ");
                    sw.WriteLine(c.PrecioTotal.ToString());
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
