using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesMan
{
    internal class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        //---Constructors---
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight) :this(model, engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color) :this(model, engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        //---Properties---
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
