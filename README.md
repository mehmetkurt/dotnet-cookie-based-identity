# .NET 6 Identity Cookie Based Authentication

## What's this?

Everyone knows, if you start a new project you've to implement core things like: Authentication, Authorization, User management, Roles management, Logging, Errorhandling etc...

I was tired of doing so and created this boilerplate. I was isnpired by this Article [ASP.NET Core: From Beginner to advanced](https://burakneis.com/asp-net-core-identity/)

This boilerplate provides the following features:

* using .NET Core 6
* using entity Framework
* supports MySql, MariaDb and SqlServer
* Provides Authentication with Identity Framework and LDAP
    * Login
    * Register
    * Forgot Password
    * Change Password
    * optional email verification
    * 2fa by Authenticator App (Microsoft or Google)
    * 2fa by email
* Provides Authorization
    * Claim based
    * role based
* provides global error handling
    * for status errors
    * for exceptions
* provides application settings service
    * easy to extend settings service with own settings classes
* provides session cache in database
* provides session timeout due to inactivity
* provides loggin using serilog
    * audit logging
    * exception logging
    * application logging
* provides usermanagement
    * create, edit users
    * enforce 2fa
    * set ldap login
    * assign roles
    * enable / disable users
* provides role management
    * create / edit roles
* provides user selfservice
    * reset password
    * change password
    * edit profile
    * edit profile picture (stored in database)
* provides a bootstrap based theme
    * only three layout files (Main, Auth, Error)
    * easy to customize
* provides doxygen generated class documentation\
    * take a look [here](https://htmlpreview.github.io/?https://github.com/madcoda9000/dotnet-cookie-based-identity/blob/main/Documentation/generated/html/index.html)

### Huhhh, sounds interesting! Can i take a look at it?

sure, I've prepared a few [Screesnhots](Documntation/SCREENSHOTS.md) for you!

### Damn! You've coded that all by yourself?

No! I've used the following Librarys / Projects in this Project:

* Parts of this Article [ASP.NET Core: From Beginner to advanced](https://burakneis.com/asp-net-core-identity/)
* [DatatablesJs](https://github.com/ekondur/DatatableJS) (I've modified that and included the modified source [here](DatatablesJs). The changes I've made are documented [here](https://github.com/ekondur/DatatableJS/issues)
* [DoxyGen](Https://doxygen.nl) for generating the class documantation, which can be found [here](Documentation/generated/html/)
* [Bootstrap 5.1](https://bootstrap.com) for creating the layouts
* [Jquery](https://jquery.com) for making javascript easier :-)
* [Toastify](https://apvarun.github.io/toastify-js/) for creating nice toast messages

### Ahhh, that's exactly what i need. How can i use that?

so, then take a look at the install [instrunctions](Documentation/INSTALLmd)
