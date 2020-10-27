using System;


public delegate void ReverseGearDelegate(string ow);

namespace CustomEvent
{
    public class Car
    {
        private int distance;

        public int Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                if(distance <= 3)
                {
                    //event will be raised at this point
                    this.ReverseGear("Warning check your distance....!!!!!");
                }
            }
        }
        public event ReverseGearDelegate ReverseGear;
        public string OwnerName ;

        public void Warning(string Owner)
        {
            Console.WriteLine(Owner);
            Console.ReadLine();
        }
        
    }

    public class CarDecor
    {
        public static void Main()
        {
            Car maruti = new Car();
            maruti.ReverseGear += new ReverseGearDelegate(maruti.Warning);
            maruti.Distance = 4;
        }
    }
}
