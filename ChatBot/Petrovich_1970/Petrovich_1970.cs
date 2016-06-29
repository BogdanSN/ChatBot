using BotSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrovich_1970
{
    public class Petrovich_1970 : IBot
    {
        public string Answer(string message)
        {
            if (message.Equals("Hi", StringComparison.InvariantCultureIgnoreCase))
                return "Да ти шо, шо по англійські шпрехаєш";
            else if (message.Equals("how do you do", StringComparison.InvariantCultureIgnoreCase))
                return "До того як півко закончилось - все було гуд";
            else if (message.Equals("Bear", StringComparison.InvariantCultureIgnoreCase))
                return "Хтось шукає взвод на літр піва ?";
            else
                return null;
        }

        public string Name
        {
            get { return "Петрович_1970"; }
        }
    }
 
}

