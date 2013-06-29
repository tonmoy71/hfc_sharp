using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Testing_this_tonmoy
{
    class Contact
    {
        public string name;
        public int age;

        public void showInfo()
        {
            MessageBox.Show("Name is " + name + " and Age is: " + age);
        }
    }
            

    
}
