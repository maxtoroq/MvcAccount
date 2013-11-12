// Copyright 2012 Max Toro Q.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcAccount.Shared;
using MvcCodeRouting.Web.Mvc;

namespace MvcAccount.Email.Verify {
   
   /// <summary>
   /// Exposes e-mail verification functionality.
   /// </summary>
   public class VerifyController : BaseController {

      AccountRepositoryWrapper repo;

      /// <summary>
      /// Initializes a new instance of the <see cref="VerifyController"/> class.
      /// </summary>
      public VerifyController() { }

      /// <summary>
      /// Initializes a new instance of the <see cref="VerifyController"/> class, 
      /// with the provided <paramref name="repo"/>.
      /// </summary>
      /// <param name="repo">The account repository.</param>
      public VerifyController(AccountRepository repo) 
         : this() { 

         this.repo = new AccountRepositoryWrapper(repo);
      }

      /// <summary>
      /// Initializes data that might not be available when the constructor is called.
      /// </summary>
      /// <param name="requestContext">The HTTP context and route data.</param>
      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         this.repo = this.Configuration.RequireDependency(this.repo);
      }

      /// <summary>
      /// E-mail verification callback.
      /// </summary>
      /// <param name="id">The verification ticket.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      [DefaultAction]
      public ActionResult Verify(string id) {

         var result = VerifyImpl(id);

         if (result.IsError)
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());

         return View();
      }

      OperationResult VerifyImpl(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null)
            return HttpStatusCode.NotFound;

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.EmailVerified
            || user.EmailVerificationTicketExpiration == null
            || user.EmailVerificationTicketExpiration.Value < this.Configuration.GetNow())
            return HttpStatusCode.Gone;

         user.EmailVerified = true;
         user.EmailVerificationTicketExpiration = null;

         if (this.Configuration.EmailVerificationEnablesUser)
            user.Disabled = false;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }
   }
}