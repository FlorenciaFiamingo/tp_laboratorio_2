using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_2017
{
    public class Dulce : Producto
    {
        private short _cantidadCalorias;

        public Dulce(EMarca marca, string codBarra, ConsoleColor color):base(marca, codBarra, color)
        {
            this._cantidadCalorias = 80;
        }
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return this._cantidadCalorias;
            }
            set
            {
               this._cantidadCalorias = value;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine((string)this);
            sb.AppendLine("CALORIAS : {0}"+ this.CantidadCalorias.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
