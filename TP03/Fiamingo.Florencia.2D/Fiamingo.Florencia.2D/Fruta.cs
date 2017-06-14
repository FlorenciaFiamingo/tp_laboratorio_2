using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiamingo.Florencia._2D
{
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        public abstract bool TieneCarozo
        {
            get;
        }

        protected virtual string FrutaToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Color: " + this._color.ToString());
            retorno.AppendLine("Peso: " + this._peso.ToString());
            retorno.AppendLine("Tiene carozo? " + this.TieneCarozo.ToString());

            return retorno.ToString();
        }
    }
}
