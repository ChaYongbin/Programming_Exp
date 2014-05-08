using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lec140501
{
    class Timer
    {
        public static void PrintSec(int hour, int min, int sec)
        {
            int tosec = (hour * 3600) + (min * 60) + sec;
            
            if (hour == 0 & min == 0 & sec == 0 )
            {
                Console.WriteLine("");
            }
            else
            {
                while (tosec > 0)
                {
                    tosec--;
                    hour = tosec / 3600;
                    min = (tosec - hour * 3600) / 60;
                    sec = (tosec - hour * 3600 - min * 60);

                    Console.WriteLine("{0:00} : {1:00} : {2:00}", hour, min, sec);
                    Thread.Sleep(1000);
                }
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------타이머-----------------------------");
            Console.WriteLine("시 분 초를 차례대로 입력을 하세요 (예) 1시간 1분 10초 => 1 1 10");
            string l = Console.ReadLine();
            string[] ll = l.Split();

            int a = Convert.ToInt32(ll[0]);
            int b = Convert.ToInt32(ll[1]);
            int c = Convert.ToInt32(ll[2]);

            Timer.PrintSec(a, b, c);
            Console.WriteLine("Bye");
        }
    }
}
