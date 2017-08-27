using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Armor : Item
    {
        public int MinimumArmor { get; set; }
        public int MaximumArmor { get; set; }

        public Armor(int id, string name, string namePlural, int minimumArmor, int maximumArmor) : base(id, name, namePlural)
        {
            MinimumArmor = minimumArmor;
            MaximumArmor = maximumArmor;
        }
    }
}
