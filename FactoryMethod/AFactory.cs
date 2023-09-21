using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public abstract class Coffee
    {
        public ListBox listBox;
        public abstract void show();
    }

    public abstract class CoffeeHouse
    {
        public abstract Coffee MakeCofee();
    }
}
