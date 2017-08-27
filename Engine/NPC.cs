using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC : Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public NPC(int id, string name, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
        }
    }
}
