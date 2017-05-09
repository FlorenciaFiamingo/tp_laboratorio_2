using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }

        public ETipo _tipo;
        private short _cantidadCalorias;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codBarras, ConsoleColor color, ETipo tipo): base(marca, codBarras, color)
        {
            this._tipo = ETipo.Entera;
            this._cantidadCalorias = 20;
        }

        public Leche(EMarca marca, string codBarras, ConsoleColor color): this(marca, codBarras, color, ETipo.Entera)
        { 
        
        }

        /// <summary>
        /// Las leches tienen 20 calorías
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

            sb.AppendLine("LECHE");
            sb.AppendLine(this.ToString());
            sb.AppendLine("CALORIAS : {0}"+ this.CantidadCalorias.ToString());
            sb.AppendLine("TIPO : " + this._tipo.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
