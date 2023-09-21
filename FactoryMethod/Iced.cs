using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class IcedCoffee : Coffee
    {
        public override void show()
        {
            listBox.Items.Add($"{this.GetType().Name} has been prepered");
        }
    }

    public class IcedCofeeHouse : CoffeeHouse
    {
        public override Coffee MakeCofee()
        {
            return new IcedCoffee();
        }
    }
}
