# Simple search engine crawler for Sympli

#### Techs used in this project: .net core, reactjs(hooks), moq and xunit for unit tests

#### notation convention: for back-end parameters, private members and local variables are camel case. structures(class, interface,...), public members are pascal case
#### for front-end everything is in camel case except structures like class, components, and ...

## Some notes
By Implementing ISearchEngine interface you can add as many as search engines you like to the app. Google and Bing are added as a sample. and the user can choose.
since the test mentioned not to use the 3rd party framework I could use moles to mock extensions method for cache, so just instantiated it manually.
if I had some more time I would use latest version of C# and also deploy the project somewhere online for better demonstration. 

## If it was a real project
- I would have a separate implementation factory to add different implementations of the same interface.
- I would separate the front end from back end in different solutions.
- I would add typescript to client side development.
- I would add unit tests with jest to client-side.
- I would have unit tests for action methods in controllers.
- I would make the methods in the services more reuseable.
- I would persist data in the DB to have comparison, history, and report.

## To run the project simply (sympli :D) press the start button on Visual studio

## To build client-side for production run following command on clientApp folder

```npm run build```

## To start run the client-side without having any back end functionality run the following command on clientApp folder
```npm start```
