﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, 
            Campagnola, 
            Arcor, 
            Ilolay, 
            Sancor, 
            Pepsico
        }

        protected EMarca _marca;
        protected string _codigoDeBarras;
        protected ConsoleColor _colorPrimarioEmpaque;

        public Producto(EMarca marca, string codBarras, ConsoleColor colorPrimarioEmpaque)
        {
            this._marca = marca;
            this._codigoDeBarras = codBarras;
            this._colorPrimarioEmpaque = colorPrimarioEmpaque;      
        }

        protected abstract short CantidadCalorias { get; set; }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: "+ p._codigoDeBarras);
            sb.AppendLine("MARCA          : "+  p._marca.ToString());
            sb.AppendLine("COLOR EMPAQUE  : "+ p._colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            bool retorno = false;

            if(v1._codigoDeBarras == v2._codigoDeBarras)
            {
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1._codigoDeBarras == v2._codigoDeBarras);
        }
    }
}
