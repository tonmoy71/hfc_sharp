using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Swap
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            System.Windows.Forms.MessageBox.Show("My ears are " + EarSize +
                " inches tall", Name + " says...");
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            System.Windows.Forms.MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this);
        }





    }
}
