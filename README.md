# VSTest Target Framework Test Case

This testcase demonstrates that `dotnet test` command executes tests with compatibility level of .NET 4.5.1 / .NET 4.5.2 regardless of the target framework for which the tests are compiled.

## Scenario

  * cd ExampleTest
  * dotnet test - the test will fail with 'Could not create SSL/TLS secure channel' error

The test project is compiled for .NET Framework 4.7.1, but TestHost.exe that executes the tests is compiled for .NET Framework 4.5.x

## Cross check

  * cd ConsoleApp
  * dotnet run - will write 'All fine'.

This is a simple console program that runs the same test and is compiled for .NET Framework 4.7.1

