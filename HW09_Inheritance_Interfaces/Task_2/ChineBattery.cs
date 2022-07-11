using System;

namespace ProjectCSharp
{
    class ChineBattery : Battery
    {
        Random random = new Random();

        int charge;

        public ChineBattery()
        {
            charge = random.Next(1, 7);
        }

        public ChineBattery(int charge)
        {
            if (charge >= 1 && charge <= 7)
            {
                this.charge = charge;
            }
        }

        public override bool Descrease()
        {
            if (charge > 0)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        charge--;
                        break;
                    case 2:
                        charge -= 2;
                        break;
                }
                return true;
            }
            return false;
        }
    }
}
