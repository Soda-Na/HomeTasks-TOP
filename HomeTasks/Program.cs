using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{

    class Device
    {
        public virtual string Sound { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public Device(string sound, string name, string description)
        {
            Sound = sound;
            Name = name;
            Description = description;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}");
        }
    }

    class Kettle : Device
    {
        public Kettle(
            string sound = "bzz", 
            string name = "Kettle", 
            string description = "This is a kettle"
            ) : base(sound, name, description)
        {
        }
    }

    class Microwave : Device
    {
        public Microwave(
            string sound = "bzz", 
            string name = "Microwave", 
            string description = "This is a microwave"
            ) : base(sound, name, description)
        {
        }
    }

    class Auto : Device
    {
        public Auto(
            string sound = "bip", 
            string name = "Auto", 
            string description = "This is a auto"
            ) : base(sound, name, description)
        {
        }
    }

    class Streamboat : Device
    {
        public Streamboat(
            string sound = "bip", 
            string name = "Streamboat", 
            string description = "This is a stremaboat"
            ) : base(sound, name, description)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle();
            kettle.MakeSound();
            kettle.ShowInfo();

            Microwave microwave = new Microwave();
            microwave.MakeSound();
            microwave.ShowInfo();

            Auto auto = new Auto();
            auto.MakeSound();
            auto.ShowInfo();

            Streamboat streamboat = new Streamboat();
            streamboat.MakeSound();
            streamboat.ShowInfo();
        }
    }
}
