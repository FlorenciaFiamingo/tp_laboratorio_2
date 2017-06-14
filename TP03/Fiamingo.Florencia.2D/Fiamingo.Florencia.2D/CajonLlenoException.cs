using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiamingo.Florencia._2D
{
    public class CajonLlenoException: Exception
    {
        public CajonLlenoException()
            : base("Cajón lleno!!!")
        { 
        
        }
    }
}
