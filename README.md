# Labs-OutParameters-PassingObjectIntoMethod
## Homework Instructions
### Lab 1 : Out parameters  
Declare a method which inputs three integers and returns the product ie the value of the three numbers multiplied together. Also return an out parameter which contains the sum of the three integers.
### Lab 2 : Passing an object into a method 
Create a Cat class which has a name and an age property. 
Create a constructor method also.  
In the Methods class, create a static method called Age() which takes a Cat object as an input parameter. Inside the method, add 5 years to the age of the cat passed in.  
Instantiate a Cat instance cat01 in the Main() method. In the constructor pass in the name as 'Tibby' with age 2.  Pass the Cat instance into the Age() method. 
Repeat this another time so the Age() method is called twice in all.  
Use these two lines  using System.Web.Script.Serialization; (note you must add a Reference first - you will have to Google for the reference name to add)  and  var json = new JavaScriptSerializer().Serialize(cat01);  to help you serialize the final cat object into JSON and return this JSON string.  
{"name":"tibby","age":12}
## Implementation
### Lab 1
A class named OutParameters was created which would contain all the required methods needed to
* Read inputs from the user
* Calculate the product by multiplying all inputs and out the sum value
* Display the output

An instance of OutParameters is created in the Program class 
### Lab 2
To implement this lab two additional classes were created 
* Cat
* Methods

Cat has properties of name and age. These are public so that instances of Cat can have their properties manipulated by other classes.

Cat also has a constructor to pass in the name and the age during instantiation.

In the Program class a For Loop is used to pass the cat instance into the Age method found in the Methods class multiple times.

The Methods class has two methods
* Age
* DisplaySerializeCatJSON

To use the Age method a cat instance must be passed as an argument. Age increments the cats age property by 5.

DisplaySerializeCatJSON serializes the cat instance and outputs the JSON string to console.
