using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankest
{
    abstract class Extras
    {
        public void ShowHome(){
            Home_Page Home = new Home_Page();
            Home.Show();
        }
    }
}
