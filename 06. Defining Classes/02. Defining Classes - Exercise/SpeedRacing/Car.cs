using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        //----------Fields-----------
        private string model;
        private double fuelamount;
        private double fuelconsumptionperkilometer;
        private double travelleddistance;

        //----------Constructor-----------
        public Car(string model, double fuelAmount, double fuelConsmptPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsmptPerKm;
            this.TravelledDistance = 0;
        }

        //--------Properties--------
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelamount; }
            set { fuelamount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return fuelconsumptionperkilometer; }
            set { fuelconsumptionperkilometer = value; }
        }

        public double TravelledDistance
        {
            get { return travelleddistance; }
            set { travelleddistance = value; }
        }

        //--------Method--------
        public Car Drive(Car car, double amountOfKm)
        {
            if (car.FuelAmount >= (amountOfKm*car.FuelConsumptionPerKilometer))
            {
                car.FuelAmount -= amountOfKm*car.FuelConsumptionPerKilometer;
                car.TravelledDistance += amountOfKm;
                return car;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return car;
            }
        }

    }
}
