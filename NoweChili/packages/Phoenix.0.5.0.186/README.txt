Phoenix Framework
=================

/*********** 
* What is it
************/

Phoenix is a MVVM and MVC Hybrid Framework for WPF and Windows Phone 7. 

MVVM+Controller is modelled off Asp.net MVC style of MVC, but we take advantage of the rich binding capabilities of WPF and Silverlight to give you the best of both worlds.

The framework addresses many of the shortcomings of the MVVM pattern, such as:

 - Overly complex viewmodels, which deal with data manipulation, view concerns, and often are a mix of business logic and model transformation so it can be bound using MVVM.
 - A mix of background threads and UI threads with runtime exceptions when you get it wrong
 - Often very low cohesion and high coupling to multiple model sources (WCF services, or Rest)

/****************
* Getting Started
*****************/

I highly suggest using the Quickstart packages to get you off the ground, each quickstart will give you an Initial Controller, a default View and a ViewModel so you can see how Phoenix works.

Once you install the quickstart open the 'Getting Started with Phoenix.txt' file for instructions about additional steps to get your project running. 
Alternatively use the Phoenix project templates to get started quciker with no Additional Steps!

/************
* Conventions
*************/

Like ASP.net, Phoenix resolves controllers and views based on conventions. ViewModels are passed to the PageActionResult, so they can be placed anywhere.
Controllers simply have to end with 'Controller' to be discovered, views are more flexible, but it is recommended you use this structure:

MyProject
 |- Controllers
    |- HomeController
 |- Views
    |- Home
	   |- Index.xaml
	   |- SomePage.xaml
	   |- AnotherView.xaml

Home.Index is the default controller action in Phoenix, if you have multiple assemblies with the same views/controller names you can qualify the controller action by using a 'Assembly;Controller.Action' syntax.

