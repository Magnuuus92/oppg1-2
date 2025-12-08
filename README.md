1. sette opp disse i mappen "oppgave1Generics"
   - Storage.cs
   - IStore.cs
2. satt opp ny mappe "Tests": dotnet new xunit -o ./Tests
   - UnitTest1.cs //Her skal jeg teste
   - linket Tests mappe til solution: dotnet sln add ./Tests
   - la til referanse mellom mappene "oppgave1Generics" og "Tests":
     dotnet add ./oppgave1Generics reference ./Tests
