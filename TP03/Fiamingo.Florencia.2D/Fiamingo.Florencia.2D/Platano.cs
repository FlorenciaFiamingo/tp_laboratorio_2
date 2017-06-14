using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiamingo.Florencia._2D
{
    public class Platano: Fruta
    {
        public string paisOrigen;

        public Platano(float peso, ConsoleColor color, string pais): base(peso, color)
        {
            this.paisOrigen = pais;
        }

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo
        {
            get { return this.ToString(); }
        }

        protected override string FrutaToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.FrutaToString());
            retorno.AppendLine("Pais: " + this.paisOrigen);

            return retorno.ToString();
        }

        public string ToString()
        {
            return this.FrutaToString();
        }
    }
}
