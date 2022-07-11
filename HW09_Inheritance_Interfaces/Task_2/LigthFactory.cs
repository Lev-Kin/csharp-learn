
namespace ProjectCSharp
{
    class LigthFactory
    {
        class Flashlight : Illuminant
        {
            private Battery battery;
            public bool Ligth { get; set; } = false;

            protected internal Flashlight(Battery battery)
            {
                this.battery = battery;
            }

            protected internal Flashlight()
            {
                battery = new ChineBattery();
            }

            public bool IsLigth()
            {
                if (Ligth)
                {
                    return true;
                }
                else
                    return false;
            }

            public void Off()
            {
                Ligth = false;
            }

            public bool On()
            {
                if (battery.Descrease())
                {
                    if (Ligth != true)
                    {
                        Ligth = true;
                        return true;
                    }
                }

                Ligth = false;
                return false;
            }
        }

        public Illuminant GetFlashlight(Battery battery)
        {
            Illuminant illuminant = new Flashlight(battery);
            return illuminant;
        }
    }
}
