using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4_2
{
    class Clock
    {
        public Ticker ticker = new Ticker();
        public Alarmer alarmer = new Alarmer();
        private int hour;
        private int minute;
        private int second;
        
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value > -1 && value < 24)
                    hour = value;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value > -1 && value < 60)
                    minute = value;
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value > -1 && value < 60)
                    second = value;
            }
        }
        public Clock(int hour,int minute,int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            ticker.Tick += Clock_Tick;
            alarmer.Alarm += Clock_alarm;
        }
        

        private void Clock_Tick(Object sender)
        {
            Console.WriteLine("tick");
        }
        private void Clock_alarm(Object sender)
        {
            Console.WriteLine("alarm");
        }
        public void StartTiming(int H,int M,int S)
        {
            while(true)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"当前时间为:{hour}:{minute}:{second}");
                if (H == hour && S == second && M == minute)
                    alarmer.StartAlarm();
                if (this.second<59)
                {
                    second += 1;
                    ticker.StartTick();
                }
                else if(minute<59)
                {
                    minute += 1;
                    Second = 0;
                    ticker.StartTick();
                }
                else
                {
                    hour=(hour+1)%24;
                    Second = 0;
                    Minute = 0;
                    ticker.StartTick();
                }
            }
        }
    }
}
