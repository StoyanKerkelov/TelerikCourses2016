﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class Call
    {
        private DateTime date = new DateTime(2027, 3, 1);
        private DateTime time = new DateTime(2027, 3, 1, 0, 0, 0);
        private string phoneNumber = null;
        private ushort duration = 0;

        public Call(DateTime date, DateTime time, string phoneNumber, ushort duration)
        {
            this.date = date;
            this.time = time;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number can not be missing.");
                }
                phoneNumber = value;
            }
        }

        public ushort Duration
        {
            get { return duration; }
            set {
                    if (value<0)
                    {
                        throw new ArgumentException("Call duration is always positive number");
                    }
                duration = value; }
        }

        public override string ToString()
        {
            return string.Format(
                "\n\nCall Info: " +
                "\nMade On: {0}" +
                "\nMade At: {1}" +
                "\nMade To: {2:### ## ## ##}" +
                "\nDuration: {3} sec.",
                this.date.ToString("dd.mm.yyyy"), this.time.ToString("hh:mm:ss"), this.phoneNumber, this.duration
                );
        }
    }
}
