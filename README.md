1. sette opp disse i mappen "oppgave1Generics"
   - Storage.cs
   - IStore.cs
2. satt opp ny mappe "Tests": dotnet new xunit -o ./Tests
   - UnitTest1.cs //Her skal jeg teste
   - linket Tests mappe til solution: dotnet sln add ./Tests
   - la til referanse mellom mappene "oppgave1Generics" og "Tests":
     dotnet add ./oppgave1Generics reference ./Tests
3. Problem med at noe ikke er linket til sln eller et prosjket. Feilmelding:
   "current document is outside of any project opened"
   - fikk lagt til UnitTests1.cs i Tests mappen ved å bruke add project reference i solution explorer
   - README erfortsatt utenfor da, men finner ikke noen løsning på det.
4. .gitignore allerede tracked filer med "open integrated termingal og: "git rm -r --cached bin obj" husk å save i .gitignore etterpå
5. - bruke unit Tests.
6. Ny error: error MSB4006: There is a circular dependency in the target dependency graph involving target "\_GenerateRestoreProjectPathWalk"

- Jeg hadde brukt refrence dobbelt opp. tests.csproj og oppgave1Generics.csproj. Fjernet ref fra Tests.csproj.
