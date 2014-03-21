Changes
=======

v0.12.0
-------
- Fixed #5: Cannot override template for input model in EditorTemplates
- Fixed #7: Use type="email"
- Fixes #8: Leverage MVC 5.1 htmlAttributes support for class="form-control"

v0.11.0
-------
- Bootstrap CSS compatibility
- Changed submit text of sign in, change password and change email views.
- Added cancel button on change password and change email
- Fixed #2: Use DataType.EmailAddress
- Added CryptoPasswordService (PBKDF2)
- Added FormsAuthenticationService.CreateFormsAuthenticationTicket method

BREAKING CHANGES:
- Auth namespace renamed to Authentication
- Passing view title to layout via `Page.Title`, no longer requiring a head section.
- Added specialized resources for all submit buttons

v0.10.0
-------
- Fixed #3: Exception while resetting password
- Fixed #4: Incompatibility with NotFoundMvc, setting `TrySkipIisCustomErrors = true` for error responses.

BREAKING CHANGES:
- PasswordLengthAttribute moved to root namespace
- Namespace refactor (hopefully the last one)
  - Web subnamespace removed
  - Shared view models and base controller moved to Shared subnamespace
- Made HtmlUtility internal, simplified view code by making LinkModel implement IHtmlString, and adding HtmlHelperForInput method to FormViewModel.
- Localized resources moved to separate NuGet satellite packages

v0.9.0
------
BREAKING CHANGES:
- Major refactor which affects namespaces, routes, resources, views and CSS. Functionality remains the same.
- Depending on MvcCodeRouting