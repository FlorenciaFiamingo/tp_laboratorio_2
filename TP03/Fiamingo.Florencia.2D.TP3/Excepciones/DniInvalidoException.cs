using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException: Exception
    {
        public DniInvalidoException(string mensaje, Exception e)
            : base(mensaje, e)
        {

        }

        public DniInvalidoException(string mensaje)
            : this("Dni inválido", null)
        {

        }

        public DniInvalidoException(Exception e)
            : this("Dni inválido", e)
        {

        }

        public DniInvalidoException()
            : this("Dni inválido")
        {

        }
    }
}
