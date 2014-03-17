using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcAccount;

namespace SampleWebsite.Models {
   
   public class TestAccountRepository : AccountRepository {

      static readonly List<User> users = new List<User> { 
         new User { Id = 1, Username = "demo", Password = "demo", Email = "demo@example.com" }
      };

      public override object FindUserById(object id) {
         return users.SingleOrDefault(u => u.Id == Convert.ToInt32(id));
      }

      public override object FindUserByName(string username) {
         return users.SingleOrDefault(u => u.Username == username);
      }

      public override object FindUserByEmail(string email) {
         return users.SingleOrDefault(u => u.Email == email);
      }

      public override void UpdateUser(object user) {

      }
   }
}