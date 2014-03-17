using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebsite.Models {

   public class User {

      public int Id { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }
      public string Email { get; set; }

      public DateTime? LastSignIn { get; set; }
      public bool EmailVerified { get; set; }
      public bool Disabled { get; set; }

      public int FailedSignInAttempts { get; set; }
      public DateTime? FailedSignInAttemptWindowStart { get; set; }

      public DateTime? EmailVerificationTicketExpiration { get; set; }
      public DateTime? PasswordResetTicketExpiration { get; set; }
      public DateTime? EmailChangeTicketExpiration { get; set; }
   }
}