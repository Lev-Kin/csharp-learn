
namespace ProjectCSharp
{
    class Duracell : Battery
    {
        int charge;

        public Duracell()
        {
            charge = 70;
        }

        public Duracell(int charge)
        {
            if (charge >= 10 && charge <= 100)
            {
                this.charge = charge;
            }
        }

        public override bool Descrease()
        {
            if (charge > 0)
            {
                charge--;
                return true;
            }
            return false;
        }
    }
}
