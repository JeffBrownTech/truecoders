using ClassesDemo;

var csharpClass = new Classroom();

// Person jeff = new Person();  // This is calling the Person constructor

var jeff = new Person();

// Use dot notation to assign values to properties
jeff.Name = "Jeff";
jeff.Age = 40;
jeff.clothes = "hoodie and pants";
jeff.wallet = 350;

// jeff.Greet();

csharpClass.CodingClass.Add(jeff);


// Object initializer syntax, fill the properties when creating the object
var bob = new Person()
{
    Name = "Bob",
    Age = 30,
    clothes = "tuxedo",
    wallet = 350
};

// bob.Greet();

csharpClass.CodingClass.Add(bob);


// Using a custom constuctor
var april = new Person("April", 35);
// april.Greet();
csharpClass.CodingClass.Add(april);

csharpClass.GreetEveryone();
