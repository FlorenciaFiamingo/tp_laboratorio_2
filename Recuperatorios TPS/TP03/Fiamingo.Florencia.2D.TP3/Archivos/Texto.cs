using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;


namespace Archivos
{
    public class Texto
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo, true))
                {
                    file.WriteLine(datos);
                }
                return true;

            }
            catch (ArchivosException e)
            {
                throw e.InnerException;
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader file = new StreamReader(archivo, true))
                {
                    datos = file.ReadToEnd();
                }
                return true;
            }
            catch (ArchivosException e)
            {
                throw e.InnerException;
            }
        }
    }
}
