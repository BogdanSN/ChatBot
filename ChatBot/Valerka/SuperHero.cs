using BotSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerka
{
    public class SuperHero : IBot
    {
        public string Answer(string message)
        {
            if (message.Equals("Hi", StringComparison.InvariantCultureIgnoreCase))
                return "Gooten Morgen";
            else if (message.Equals("how do you do", StringComparison.InvariantCultureIgnoreCase))
                return "Fantsatish";
            else if (message.Equals("Fritz", StringComparison.InvariantCultureIgnoreCase))
                return "Königin Morgan in Gefahr, Aufmerksamkeit, ich werde helfen";
            else
                return null;
        }

        public string Name
        {
            get { return "Super Fritz"; }
        }
    }
}
