using BotSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botan
{
    public class Botan : IBot
    {
        public string Answer(string message)
        {
            if (message.Equals("Hi", StringComparison.InvariantCultureIgnoreCase))
                return "Gena Solomonovich on line";
            else if (message.Equals("how do you do", StringComparison.InvariantCultureIgnoreCase))
                return "All is ok except arabians";
            else if (message.Equals("Gena", StringComparison.InvariantCultureIgnoreCase))
                return "С точки зрения банальной эрудиции каждый здравый индивидуум склонен к проявлениям парадоксальных заключений";
            else
                return null;
        }

        public string Name
        {
            get { return "Генадий Соломонович"; }
        }
    }
}

