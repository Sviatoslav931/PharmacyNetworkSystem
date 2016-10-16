using PharmaEntities;
using System;

namespace PharmaShop.Code
{
    public class CurrentUser
    {
        private static User currentUser;

        public static void Initialize(User user)
        {
            if (currentUser != null)
            {
                throw new InvalidOperationException("Current user has already been specified.");
            }
            currentUser = user;
        }

        public static int Id => currentUser.Id;

        public static string FirstName => currentUser.FirstName;

        public static string Surname => currentUser.Surname;

        public static string Login => currentUser.Login;

        public static string Role => currentUser.Role;

        public static int ShopID => currentUser.ShopID;
    }
}
