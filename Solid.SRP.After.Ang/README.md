# Solid.SRP.After.Ang

### This project is the AngularJS version of Solid.SRP.After (WPF) project.

### Technologies Used

1. Visual Studio Community 2017,
2. AngularJS,
3. Angular CLI, version 6.0.8: used to create, test, and build the AngularJS app,
4. TypeScript 2.0 with TypeScript Compiler (tsc) for Visual Studio,
5. NG Bootstrap: an AngularJS Bootstrap Module for zero-jQuery styling of the AngularJS app,
	* NG Bootstrap was used only in App Component's Template (app.component.html) for minimal, responsive styling.

### Usage

* *Source Code is available in __'/src/app'__ folder*,
* *The AngularJS application was pre-compiled in PROD mode, using the '--base-href' flag*, therefore the folder '__/dist/Solid.SRP.After.Ang__' can be directly downloaded to hard drive, and the webpage '__*index.html*__' can be opened in any browser to view the working application.


### Project Details

__'src/app' folder contains all source code for the AngularJS application. The sub-folders are described below.__

* *__/Business__ folder contains all business classes and interfaces (e.g. Mediator, IColleague, etc.), implemented in TypeScript, to be used from AngularJS components,*
* *__/Models__ folder contains the data class for Color Item, and an __Injectable__ service (__ColorItemsService__), which is injected into an __Angular Component__ via its constructor,*
* *__/Styles__ folder contains CSS files specific to individual (HTML) Component Templates,*
* *__/ViewModels__ folder contains TypeScript class files for individual Angular Components: __Angular Components__ are treated as __ViewModels__ that communicate with each other via the __Mediator__ class.* Each Component (or ViewModel) extends __BaseVM__, the base ViewModel class. 
* *__/Views__ folder contains __AngularJS Component Templates__, that are treated as __Views__ in the MVVM design. AngularJS syntax is used to bind property values and events defined in __ViewModels__, to UI elements in __Views__.*
* *__/app__ (__root__) folder contains definitions for __App Component__, __App Component's Template__, and CSS file for __App Component's Template__:*
	* *the three __Angular Components__ (described above) are used as nested components in the main __App Component__,*
    * *__App Component's Template__ (app.component.html) uses Angular directives to arrange the three __Views__ defined in __/Views__ folder (above); each of these directives is defined in the __'selector'__ property on the __'@Component()'__ attribute for each of the three Angular Components (__ViewModels__),*
	* *__App Component's Template__ uses __Bootstrap__ class attributes for responsive CSS styling.*
* *__/app__ (__root__) folder also contains the definition for the only __Angular Module__ (__AppModule__) used in the application, defined in 'app.module.ts.'*
