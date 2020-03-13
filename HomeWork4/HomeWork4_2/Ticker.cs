using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4_2
{
    class Ticker
    {
        public event Action<Object> Tick;
        public void StartTick()
        {
            Tick(this);
        }
    }
    class Alarmer
    {
        public event Action<Object> Alarm;
        public void StartAlarm()
        {
            Alarm(this);
        }
    }
}
