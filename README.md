# Creating This Solution

From the command Prompt:
```powershell
dotnet new sln -o BankingSolution
cd .\BankingSolution
dotnet new classlib -o BankingDomain
dotnet new xunit -o BankingUnitTests
dotnet sln add .\BankingDomain\BankingDomain.csproj
dotnet sln add .\BankingUnitTests\BankingUnitTests.csproj

```

To add a reference from the Xunit project to the domain:

```powershell
 cd .\BankingUnitTests\
dotnet add reference ..\BankingDomain\BankingDomain.csproj 

```

Note: You can also just directly edit the `.csproj` file like this:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>

    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.11.0" />
    <PackageReference Include="xunit" Version="2.4.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.4.3">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="coverlet.collector" Version="3.1.0">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\BankingDomain\BankingDomain.csproj" />
  </ItemGroup>

</Project>

```