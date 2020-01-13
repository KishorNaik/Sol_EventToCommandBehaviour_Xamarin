using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Services
{
    public class UserService
    {
        public IEnumerable<UsersModel> GetUserData()
        {
            var listUserObj = new List<UsersModel>();
            listUserObj.Add(new UsersModel()
            {
                FirstName = "Kishor",
                LastName = "Naik"
            });
            listUserObj.Add(new UsersModel()
            {
                FirstName = "Eshaan",
                LastName = "Naik"
            });

            return listUserObj;
        }
    }
}
