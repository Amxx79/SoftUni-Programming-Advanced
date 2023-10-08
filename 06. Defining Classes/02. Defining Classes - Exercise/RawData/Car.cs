using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tyre[] tires;

        public Car(string model,int engineSpeed,int enginePower,int cargoWeight,string cargoType,
                   double tire1Pressure,int tire1Age,double tire2Pressure,int tire2Age,
                   double tire3Pressure,int tire3Age,double tire4Pressure,int tire4Age)
        {
            this.Model = model;
            this.Engine = new (engineSpeed, enginePower);
            this.Cargo = new (cargoWeight, cargoType);
            Tyres = new Tyre[4];
            Tyres[0] = new(tire1Pressure, tire1Age);
            Tyres[1] = new(tire2Pressure, tire2Age);
            Tyres[2] = new(tire3Pressure, tire3Age);
            Tyres[3] = new(tire4Pressure, tire4Age);
        }



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

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public Tyre[] Tyres
        {
            get { return tires; }
            set { tires = value; }
        }
    }
}
