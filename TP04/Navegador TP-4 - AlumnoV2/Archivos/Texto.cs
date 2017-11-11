using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string _archivo;

        public Texto(string archivo)
        {
            this._archivo = archivo;          
        }

        public bool guardar(string datos)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + this._archivo, true))
                {
                    sw.WriteLine(datos);
                    sw.Close();
                    return true;
                }

            }
            catch(Exception)
            {
                return false;
            }

        }

        public bool leer(out List<string> datos)
        {
            string cadena;

            try
            {
                using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + this._archivo))
                {
                    datos = new List<string>();

                    while ((cadena = sr.ReadLine()) != null)
                    {
                        datos.Add(cadena);
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
