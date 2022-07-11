namespace АТМ
{
    namespace SpaceAccount
    {
        class Account
        {
            public uint accountNumber { get; set; } = 0;
            public uint pass { get; set; } = 0;
            public double amount { get; set; } = 0.0;

            public Account(uint accountNumber, uint pass, double amount = 0.0)
            {
                this.accountNumber = accountNumber;
                this.pass = pass;
                this.amount = amount;
            }
        }
    }
}
