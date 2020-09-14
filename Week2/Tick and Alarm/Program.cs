using System;

namespace Tick_and_Alarm
{
    public class Clock
    {
        public int Hour;
        public int Minute;
        public int Second;
        public int AlarmHour;
        public int AlarmMinute;
        public int AlarmSecond;
        public delegate void TickHandler();
        public event TickHandler OnTick;
        public event TickHandler OnAlarm;

        public void Tick()
        {
            OnTick();
        }
        public void Alarm()
        {
            if (AlarmHour == Hour && AlarmMinute == Minute && AlarmSecond == Second)
                OnAlarm();
        }

        public void TimeUpdate()
        {
            Second++;
            if (Second == 60)
            {
                Second = 0;
                Minute++;
                if (Minute == 60)
                {
                    Minute = 0;
                    Hour++;
                    if (Hour == 24)
                    {
                        Hour = 0;
                    }
                }
            }
        }
    }

    class Program
    {
        private static Clock clock = new Clock();

        static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            clock.Tick();
            clock.Alarm();
            clock.TimeUpdate();
        }

        private static void Main(string[] args)
        {
            clock.OnTick += Tick;
            clock.OnAlarm += Alarm;

            void Tick()
            {
                Console.WriteLine($"Tick_当前时间：{clock.Hour}:{clock.Minute}:{clock.Second}");
            }

            void Alarm()
            {
                Console.WriteLine($"Alarm_当前时间：{clock.Hour}:{clock.Minute}:{clock.Second}");
            }

            clock.Hour = 9;
            clock.Minute = 30;
            clock.Second = 55;
            clock.AlarmHour = 9;
            clock.AlarmMinute = 31;
            clock.AlarmSecond = 00;

            System.Timers.Timer timer;
            timer = new System.Timers.Timer(1000);//设置时间间隔为1s
            timer.Elapsed += OnTimedEvent; 
            timer.AutoReset = true; //每到指定时间Elapsed事件是一直触发（true）
            timer.Enabled = true;

            Console.ReadLine();
        }
    }
}
