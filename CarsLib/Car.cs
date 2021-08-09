using System;

namespace CarsLib
{
    public class Car
    {
        public string Rego { get; set; }
        public int Speed { get; set; }

        public Car(string rego, int speed)
        {
            SetRego(rego);
            this.Speed = 0;
            AddSpeed(speed);
        }

        public void SetRego(string rego)
        {
            rego = rego.ToUpper();

            if (rego.Length > 6)
            {
                rego = rego.Substring(0, 6);
            }
            else if (rego.Length < 6)
            {
                for (int i = rego.Length; i < 6; i++)
                {
                    rego += "A";
                }
            }
            this.Rego = rego;
        }
        public void AddSpeed(int speed)
        {
            this.Speed += speed;

            if (this.Speed > 130)
            {
                this.Speed = 130;
            }
            else if (this.Speed < -10)
            {
                this.Speed = -10;
            }
        }
    }
}
