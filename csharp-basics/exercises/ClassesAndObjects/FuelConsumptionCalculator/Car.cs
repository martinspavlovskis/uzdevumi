namespace FuelConsumptionCalculator
{
    public class Car
    {
        double startKilometers;
        double endKilometers;
        double liters;

        public Car(double startOdo, double endingOdo, double Liters)
        {
            this.startKilometers = startOdo;
            this.endKilometers = startOdo;
            this.liters = 0;
        }

        public double CalculateConsumption()
        {
            if (this.endKilometers > this.startKilometers)
            {
                return this.liters / (this.endKilometers - this.startKilometers);
            } else
            {
                return 0;
            }
        }

        private double ConsumptionPer100Km()
        {
            return CalculateConsumption() * 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            this.endKilometers = mileage;
            this.liters += liters;
        }
    }
}
