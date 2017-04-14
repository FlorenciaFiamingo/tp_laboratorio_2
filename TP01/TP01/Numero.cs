using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Numero
    {
        #region Atributos

        public double numero;

        #endregion

        #region Constructores

        //No recibe parámetros, inicializa en cero.
        public Numero()
        {
            this.numero = 0;
        }

        //Recibe un double y se lo asigna a numero.
        public Numero(double numero)
        {
            this.numero = numero;
        }

        // Recibe un string, lo valida con setNumero.   
        public Numero(string numero)
        {
            setNumero(numero);
        }

        #endregion

        #region Métodos

        //Retorna el valor de numero.
        public double getNumero()
        {
            return this.numero;
        }

        // Utiliza el método validarNumero. Recibe un string y si es válido lo castea a double y se lo asigna a numero.
        // Caso contrario le asigna cero.
        private void setNumero(string numero)
        {
            if (numero != null && validarNumero(numero) != 0)
            {
                double.TryParse(numero, out this.numero);
            }
            else
            {
                this.numero = 0;
            }
        }

        // Valida que el número recibido como string sea double, de no ser así, retorna 0.
        private static double validarNumero(string numero)
        {
            double retorno = 0;

            if (numero != null && numero != "")
            {
                retorno = 1;
            }

            return retorno;

        }
        #endregion
    }
}
