using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;

namespace Fiamingo.Florencia._2D
{   
    [Serializable]
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Platano))]
    public class Cajon<T>
    {
        protected int _capacidad;
        protected static List<T> _frutas;
        protected float _precioUnitario;

        static Cajon()
        {
            Cajon<T>._frutas = new List<T>(); 
        }

        public Cajon(int capacidad)
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio):this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public List<T> Frutas
        {
            get { return Cajon<T>._frutas; }
        }

        public float PrecioTotal
        {
            get 
            {
                int aux = Cajon<T>._frutas.Count;

                float precioAux = aux * this._precioUnitario;

                return precioAux;
            }
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            try 
            {
                if (Cajon<T>._frutas.Count < c._capacidad)
                {
                    Cajon<T>._frutas.Add(f);
                }

                return c;
            }
            catch
            {
                throw new CajonLlenoException();
            }

        }

        public string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Capacidad: " + this._capacidad.ToString());
            retorno.AppendLine("Cantidad de frutas: " + Cajon<T>._frutas.Count.ToString());
            retorno.AppendLine("Precio total: " + this.PrecioTotal.ToString());

            foreach (T item in Cajon<T>._frutas)
            {
                retorno.AppendLine("Fruta: ");
                retorno.Append(item.ToString());
            }

            return retorno.ToString();
        }

        public bool SerializarXML(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
                XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);

                serializer.Serialize(writer, this);
                writer.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeserializarXML(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
            XmlTextReader reader = new XmlTextReader(path);
            Cajon<T> c;

            try
            {
                c = (Cajon<T>)serializer.Deserialize(new FileStream(path, FileMode.Open));
                this._capacidad = c._capacidad;
                this._precioUnitario = c._precioUnitario;
                
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
