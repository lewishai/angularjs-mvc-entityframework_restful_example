This project shows how to create a simply web application using angularjs, mvc and RESTful Web Service, I named it is “manage customer”.

List of features:

•	List customer

•	Edit customer

•	Create new customer

•	Delete customer


List of projects of “manage customer” application:

•	CustomerEntities (EntityFramework 6.0.0.0)

•	CustomerDAL (c# classes)

•	CustomerBLL (c# classes)

•	CustomerAPI (RESTful web service)

•	CustomerUI (AngularJs, MVC)


Notes that in customer UI will be no C# controller file, it is be replaced by angularjs script files. CustomerAPI will works with CustomerBLL to control business logic, CustomerBLL reference data layer (CustomerDAL) and CustomerDAL works CustomerEntities to query data.

Security notes.
At this application I don’t care about security for RESTFul webservice, enscrypt and descrypt connection string… you can do it more to don’t the simple application.



