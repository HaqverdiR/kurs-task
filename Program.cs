using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer Acer = new Computer(32, 250, "Intel", 2.5, "Acer");
            Acer.GetInfo();
            notebook NAcer = new notebook(8, 350, "Atom", 3.7, "Acer", true, true);
            NAcer.GetInfo();
            var Dp = new Display(50, 15);
            pc Dell = new pc(3, 500, "Intel", 1.7, "Dell", Dp);
            Dell.GetInfo();
        }
    }
    class Equipment
    {
        public int ram { get; set; }
        public int hdd { get; set; }
        public string CPU { get; set; }
        public double CpuPower { get; set; }

    }
    class Computer : Equipment
    {
        public Computer(int ram, int hdd, string Cpu, double cp, string name)
        {
            this.ram = ram;
            this.hdd = hdd;
            CPU = Cpu;
            CpuPower = cp;
            this.name = name;


        }

        public string name { get; set; }




        public virtual void GetInfo()
        {
            Console.WriteLine("Ram {0},HDD {1},CpuName {2},CpuPower {3},Name {4} ", ram, hdd, CPU, CpuPower, name);
        }

    }
    class notebook : Computer
    {
        public bool wifi { get; set; }
        public bool touchpad { get; set; }

        string wifis { get; set; }

        public notebook(int Nram, int Nhdd, string NCpu, double Ncp, string Nname,bool Nwifi,bool Ntoucpad):base(Nram, Nhdd, NCpu, Ncp, Nname)
        {
            wifi = Nwifi;
            touchpad = Ntoucpad;
            if (wifi)
            {
                wifis = "var";
            }
            else
            {
                wifis = "yoxdur";
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Ram {0},  HDD {1},CpuName {2},CpuPower {3},Name {4},Wifi {5},Touchpad {6} ", ram, hdd, CPU, CpuPower, name,wifis,touchpad);
        }

    }
    class pc : Computer
    {
        public Display monitor { get; set; }

        public pc(int Pram, int Phdd, string PCpu, double Pcp, string Pname,Display Pmonitor ):base(Pram, Phdd, PCpu, Pcp, Pname)
        {
            monitor = Pmonitor;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Ram {0},  HDD {1},CpuName {2},CpuPower {3},Name {4},Monitor Uzunluq {5}", ram, hdd, CPU, CpuPower, name,monitor.inf());
        }
    }
    class Display
    {
        public int uzunluq { get; set; }
        public int en { get; set; }

        public Display(int u, int e)
        {
           uzunluq = u;
            en = e;
        }
        public string inf()
        {
            return uzunluq + " En "+en;
        } 
    }
}
