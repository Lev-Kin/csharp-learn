
namespace ProjectCSharp
{
    abstract class Battery
    {
        int charge;
        public virtual bool Descrease()
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
