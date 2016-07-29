//Assignment #6: Properties

//Create a Project in your github directory named Homework6

//I will check your github account for Homework6

//Modify the Television class to use properties instead of functions.The Main function has already been modified to use the new properties.

//Submit a link to your github that points to your solution.For example, http://github.com/student/it-foundation/homework6


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Television
    {
        //private variables
        private int channel = 0;
        private int volume = 0;
        private bool isOn = false;

        //properties
        public int Channel
        {
            get { return channel; }
            set { channel = value; }
        }
            
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }
    }

    class TestTV
    {
        static void Main()
        {
            Television tv = new Television();

            if (!tv.IsOn)
            {
                tv.IsOn = true;
            }

            tv.Channel = 3;

            tv.Volume++;
            tv.Volume++;
            tv.Volume++;
            tv.Volume++;

            tv.IsOn = false;
        }
    }
}    