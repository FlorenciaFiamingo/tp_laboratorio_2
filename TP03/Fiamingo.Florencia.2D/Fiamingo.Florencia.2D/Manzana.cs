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
    public class Manzana: Fruta
    {
        public string distribuidora;

        public Manzana(float peso, ConsoleColor color, string distribuidora): base(peso, color)
        {
            this.distribuidora = distribuidora;
        }

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo
        {
            get { return this.ToString(); }
        }

        protected override string FrutaToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.FrutaToString());
            retorno.AppendLine("Distribuidora: " + this.distribuidora);

            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool SerializarXML(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
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

        public bool DeSerializarXML(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
            XmlTextReader reader = new XmlTextReader(path);
            Manzana l;

            try
            {
                l = (Manzana)serializer.Deserialize(new FileStream(path, FileMode.Open));
                this._color = l._color;
                this._peso = l._peso;
                this.distribuidora = l.distribuidora;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        

    }
}
