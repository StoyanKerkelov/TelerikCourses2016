﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Problem 7. Timer
//Using delegates write a class Timer that can execute certain method at each 't' seconds.

class Timer
{
    //delegate void Print(int interval);

    public static void TimerAction(Action action, int interval)
    {
        while (true)
        {
            Thread.Sleep(interval * 1000); //(Time in milliseconds)

            action();
        }
    }

    static void Main()
    {
        //int counter = 0;
        //Print printer = delegate(int i) { while (true) { Thread.Sleep(i * 1000); Console.WriteLine("Nr.{0}", ++counter); } };
        //printer(1);

        TimerAction(new Action(() => Console.WriteLine("one second have passed")), 1);// after every one seconds print 
    }
}