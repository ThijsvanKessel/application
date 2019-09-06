using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRaceTkes2
{
    class DragRaceTkes
    {
        private int counterTkes = 27;
        private int speedTkes = 0;
        private bool timerStopTkes = true;
        public double cstimeTkes = 0;

        static Random rnd = new Random();


        public DragRaceTkes(int a_counterTkes, int a_timeTkes)
        {
            counterTkes = a_counterTkes;
            cstimeTkes = a_timeTkes;
        }

        public int SetRandomTkes()
        {
            speedTkes = rnd.Next(100, 1000);
            return speedTkes;
        }

        public int GrowTkes()
        {
            if (timerStopTkes == true)
            {
                if (counterTkes <= 689)
                {
                    counterTkes = counterTkes + (speedTkes / 100);
                }
                else
                {
                    timerStopTkes = false;
                }
                cstimeTkes = cstimeTkes + 0.05;
            }

            return counterTkes;

        }

        public double timeTkes()
        {
            return cstimeTkes;
        }

        public bool TimeStopTkes()
        {
            return timerStopTkes;
        }

        public void ResetCounterTkes(int a_locationTkes, int a_speedTkes, int a_timeTkes, bool a_timerStopTkes)
        {
            counterTkes = a_locationTkes;
            speedTkes = a_speedTkes;
            cstimeTkes = a_timeTkes;
            timerStopTkes = a_timerStopTkes;
        }

        public double ResetTimeTkes()
        {
            cstimeTkes = 0;
            return cstimeTkes;
        }
    }
}
