namespace PharmaEntities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int ShopID { get; set; }
        public bool Disabled { get; set; }
    }
}
