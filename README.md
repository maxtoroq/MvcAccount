Authentication and account management plugin for ASP.NET MVC
============================================================
MvcAccount is a substitute for [MembershipProvider][1] designed for ASP.NET MVC, that provides more features and the ability to store username/password and other related data in your own database.

Get it now!
-----------
Using NuGet: `Install-Package MvcAccount`

Functions
---------
- **Sign In/Out**: With account lock out after max. invalid attempts.
- **ResetPassword**: Sends email with link to enter new password.
- **ChangePassword**: User must sign in first.
- **ChangeEmail**: With optional verification (sends email with link).

Password encryption methods
---------------------------
- **None**: Passwords are stored in clear text.
- **PBKDF2**: Passwords are hashed with the RFC 2898 algorithm ([Recommended](http://brockallen.com/2012/10/19/password-management-made-easy-in-asp-net-with-the-crypto-api/)).
  Implemented by [Crypto](http://msdn.microsoft.com/library/system.web.helpers.crypto), 
  also used by [SimpleMembershipProvider](http://msdn.microsoft.com/library/webmatrix.webdata.simplemembershipprovider).
- **SHA1**: Passwords are encrypted one-way using the SHA1 hashing algorithm (reuses [SqlMembershipProvider][2] implementation).
- **MachineKey**: Passwords are encrypted using the encryption settings determined by the machineKey element configuration (reuses [SqlMembershipProvider][2] implementation).
- **Custom**: Provide your own implementation.

Integration
-----------
- **MembershipProvider**: Although MvcAccount is a substitute for MembershipProvider there a many components out there that work against this API, so MvcAccount also provides an implementation. The only functions currently implemented are:
 - **ValidateUser** (useful if your application implements other functions that require username/password verification).
 - **GetUser** (all overloads, this allows you to get user information from your application without a direct dependency on MvcAccount).
- **Bootstrap**: Views use Bootstrap markup and classes (optional, you are not required to use Bootstrap).

Localization
------------
MvcAccount is fully localized in the following languages:

- English (en)
- Spanish (es)
- Finnish (fi)
- Portuguese (pt)

Not included
------------
MvcAccount doesn't provide the following functionality:

- Anything related with roles or claims.
- External login providers (OAuth, OpenID).

Source code and releases
------------------------
Code hosted on [GitHub][3]. Releases available via [NuGet][4].

This project was originally hosted on [CodePlex][5], source code of earlier releases remain available there for the time being.

The new codebase was restructured, although it has the same functions, it's **not** backwards compatible with earlier versions. The motivation is explained on [this post][6].

Resources
---------
- [Documentation](https://github.com/maxtoroq/MvcAccount/wiki)
- [Report an issue](https://github.com/maxtoroq/MvcAccount/issues)

<a href="https://github.com/maxtoroq/MvcAccount/wiki/Donate"><img src="http://maxtoroq.users.sourceforge.net/donate/paypal/btn_donate_SM.gif" alt="Donate"/></a>
<a href="http://flattr.com/thing/1761238/MvcAccount" target="_blank"><img src="http://api.flattr.com/button/flattr-badge-large.png" alt="Flattr this" title="Flattr this" border="0" /></a>

[1]: http://msdn.microsoft.com/library/system.web.security.membershipprovider
[2]: http://msdn.microsoft.com/library/system.web.security.sqlmembershipprovider
[3]: https://github.com/maxtoroq/MvcAccount
[4]: http://www.nuget.org/packages/MvcAccount
[5]: http://mvcaccount.codeplex.com/
[6]: http://maxtoroq.blogspot.com/2013/02/aspnet-mvc-workflow-per-controller.html
