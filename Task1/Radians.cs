using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Radians
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }

            set
            {
                gradus = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }
        public int Sec
        {
            get
            {
                return min;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Radians(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public float ToRadians()
        {
            return (float)((gradus + (min + sec / 60.0) / 60) * Math.PI / 180);
        }
    }
}
