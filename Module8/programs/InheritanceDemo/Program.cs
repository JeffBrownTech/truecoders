using InheritanceDemo;

var jeff = new Person()
{
    Name = "Jeff",
    Age = 40
};

jeff.Greet();

var bob = new Coder();
bob.Name = "Bob";
bob.Age = 30;
bob.ProgrammingLanguage = "C#";

bob.Greet();
bob.Code();

var april = new Athlete();
april.Name = "April";
april.Age = 25;
april.Sport = "basketball";
april.Greet();
april.PlaySport();

var bill = new BackEndDeveloper();
bill.Name = "Bill";
bill.Age = 35;
bill.ProgrammingLanguage = "python";
bill.Database = "MySQL";
bill.Greet();
bill.Code();