using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Calculadora
    {
        #region Atributos

        Numero numero1 = new Numero();
        Numero numero2 = new Numero();

        #endregion

        #region Métodos


        // Recibe dos números del tipo Numero y realiza la operación solicitada, utiliza validarOperador.
        // Si no puede realizar la operación retorna cero.
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;

            if (numero1 != null && numero2 != null)
            {
                operador = validarOperador(operador);

                switch (operador)
                { 
                    case "+":
                        retorno = numero1.getNumero() + numero2.getNumero();
                        break;

                    case "-":
                        retorno = numero1.getNumero() - numero2.getNumero();
                        break;

                    case "/":
                        if (numero2.getNumero() != 0)
                        {
                            retorno = numero1.getNumero() / numero2.getNumero();
                        }
                        break;

                    case "*":
                        retorno = numero1.getNumero() * numero2.getNumero();
                        break;
                }
            }

            return retorno;      

        }

        // Valida que el operador sea correcto. En caso de no serlo retorna +.
        private static string validarOperador(string operador)
        {
            string retorno = "+";

            if (operador != null && (operador.Equals("+") || operador.Equals("-") || operador.Equals("/") || operador.Equals("*")))
            {
                retorno = operador;  
            }

            return retorno;
        }

        #endregion
    }
}
