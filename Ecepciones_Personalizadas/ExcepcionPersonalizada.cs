using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecepciones_Personalizadas
{
    public class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada(string message):base(message)    
        {

        }
    }
}
