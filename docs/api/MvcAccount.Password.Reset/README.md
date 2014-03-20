MvcAccount.Password.Reset Namespace
===================================
 


Classes
-------

Class                              | Description                                                         
---------------------------------- | ------------------------------------------------------------------- 
[DoneViewModel][1]                 | Holds data for the PasswordReset view.                              
[ErrorMessageViewModel][2]         | Holds data for the ResetPasswordNotFoundMessage view.               
[FinishInput][3]                   | Holds data required by the [Finish(String, FinishInput)][4] action. 
[FinishViewModel][5]               | Holds data for the RP view.                                         
[ResetController][6]               | Exposes password reset functionality.                               
[ResetInput][7]                    | Holds data required by the [Reset(ResetInput)][8] action.           
[ResetViewModel][9]                | Holds data for the ResetPassword view.                              
[VerificationMessageViewModel][10] | Holds data for the ResetPasswordMessage view.                       
[VerificationSentViewModel][11]    | Holds data for the PasswordResetVerificationSent view.              


Enumerations
------------

Enumeration       | Description                                               
----------------- | --------------------------------------------------------- 
[ErrorReason][12] | Specifies the reason why a reset password attempt failed. 

[1]: DoneViewModel/README.md
[2]: ErrorMessageViewModel/README.md
[3]: FinishInput/README.md
[4]: ResetController/Finish_1.md
[5]: FinishViewModel/README.md
[6]: ResetController/README.md
[7]: ResetInput/README.md
[8]: ResetController/Reset_1.md
[9]: ResetViewModel/README.md
[10]: VerificationMessageViewModel/README.md
[11]: VerificationSentViewModel/README.md
[12]: ErrorReason/README.md