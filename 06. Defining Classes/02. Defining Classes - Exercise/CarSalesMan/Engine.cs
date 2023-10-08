using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesMan
{
    internal class Engine
    {
        //---Fields---
        private string model;
        private int power;
        private int displacement;
        private string efficiency;


        //---Constructors---
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency) :this(model, power)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        //---Properties---
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

    }
}
