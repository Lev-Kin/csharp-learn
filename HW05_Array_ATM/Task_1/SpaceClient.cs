namespace АТМ
{
    namespace SpaceClient
    {
        class Client
        {
            public АТМ.SpaceAccount.Account objAccount;
            public string FirstName { get; set; } = "FirstName";
            public string LastName { get; set; } = "LastName";

            public Client(string firstName, string lastName)
            {
               FirstName = firstName;
               LastName = lastName;
            }
        }
    }
}
