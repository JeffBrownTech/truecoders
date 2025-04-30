# OOP Part 4

## Debugging
- Common error types:
  - Compile Time Errors: prevent the app from compiling
  - Runtime Errors: errors that occur when the program runs (throw exceptions)
  - Logic Errors: program compiles and does not throw exception but gives unexpected results
- Exceptions are problems that occur during execution of a program

## Exception Handling
- Try-Catch-Finally Blocks
- ```System.Exception``` is the base class for all exceptions
- ```InnerException``` stores the original exception when a new exception is thrown, providing context about the underlying cause
- ```throw``` can re-throw the current exception caught by a catch block

```csharp
﻿static void Main(string[] args)
{
	StreamReader sr = null; 
	bool conditional = false;
	
	Console.WriteLine("What file would you like to read?"); 
	string path = Console.ReadLine();
	
	while (conditional)
	{
		try
		{
			sr = new StreamReader(String.Format("{0}", path));
			Console.WriteLine(sr.ReadToEnd());
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			if (sr.EndOfStream)
			{
                sr.Close();
                conditional = false;
	        }	
        }
    }
}
```

## Test-Driven Development
- Software requirements are converted to test cases before software ie fully developed
- Development work is done until all the tests pass
- Creating the tests first drives the design of code or application
- Test coverage measures the amount of code exercised by your tests, helping to identify untested parts of the application
- Acceptance testing validates that the system meets business requirements

### Unit Testing
- Validates each unit of the software until it performs as designed
- Tiny parts of the program are tested independently until they have their expected functionality
- A unit is the smallest testable part of any software (method or function)
- Unit Test Components
  - **Arrange**: Prepare the code it call the method to test (e.g. instantiating an instance of the class)
  - **Act**: Call the method to test
  - **Assert**: Check against a constant or what is the expected outcome

- Red, Green, Refactor
  - Write unit tests and watch it fail (Red)
  - Write code until test will pass (Green)
  - Improve code readability and reduce complexity without changing the behavior (Refactor)

### Testing Tools: xUnit
- Unit testing tool for .NET framework
- ```Fact``` Syntax - attribute to denote a parameterless unit test which test invariants in the code
    ```csharp
    [Fact]
    public void GetHey()
    {
        // Arrange
        ChallengesSet01 challenger = new ChallengesSet01();

        // Act
        string actual = challenger.GetHey();

        // Assert
        Assert.Equal("HEY!", actual);
    }
    ```

- ```Theory``` Syntax - Denotes a parameterized test that is true for a subset of data; data can be provided using ```InlineData``` attribute
    ```csharp
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("hello", false)]
    [InlineData("Racecar", true)]
    public void PalindromeTester(string word, bool expected)
    {
        //Arrange
        var wordSmith = new WordSmith();

        //Act
        var actual = wordSmith.IsAPalindrome(word);

        //Assert
        Assert.Equal(expected, actual);
    }
    ```

### Configuring Testing
- In the project solution, create two projects:
  - One for the main project containing classes and methods (e.g. MyProgram)
  - One for the test project contains unit tests (e.g. MyProgram.Tests)

- For the test project to know about the main project, you need to create a reference in the unit project to the main project
  - Visual Studio
    - Right-click the test project and choose **Dependencies**
    - Choose **Add Project Reference**
    - Select or check the box for the main project
    - Click **OK**
  - VS Code
    - Run the following command using the appropriate project names:
      ```dotnet add MyProgam.Tests reference MyProgram```

- What each of the above steps does is update the ```MyProgram.Tests.csproj``` file with an entry to the other project
    ```xml
    <ItemGroup>
    <ProjectReference Include="..\MyProgram\MyProgram.csproj" />
    </ItemGroup>
    ```

- Add a testing framework to the project
  - VS Code
    - Run the following command, example is for xUnit
        ```
        dotnet add UnitTestingExercise.Tests package xunit
        dotnet add UnitTestingExercise.Tests package xunit.runner.visualstudio
        ```
    - This adds the following entries to the test project's ```.csproj``` file
        ```xml
        <ItemGroup>
        <PackageReference Include="xunit" Version="2.4.2" />
        <PackageReference Include="xunit.runner.visualstudio" Version="2.4.5" />
        </ItemGroup>
        ```

  - Visual Studio
    - Right-click test project in **Solutions Explorer**
    - Select **Manage NuGet Packages**
    - Browse and search for the framework to add, click **Install**
