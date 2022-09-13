using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterRain
{
    class ModConfig
    {
        public bool useSnowDuration { get; set; }
        public int[] snowDuration { get; set; }
        public double chanceToRain { get; set; }
        public double chanceToSnow { get; set; }



        public ModConfig()
        {
            this.useSnowDuration = true;
            this.snowDuration = new int[2] {8, 21};
            this.chanceToRain = 0.183;
            this.chanceToSnow = 0.63;
        }
    }
}
