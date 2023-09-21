using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Americano : Coffee
    {
        public override void show()
        {
            listBox.Items.Add($"{this.GetType().Name} has been prepered");
        }
    }

    public class AmericanoCofeeHouse : CoffeeHouse
    {
        public override Coffee MakeCofee()
        {
            return new Americano();
        }
    }
}

