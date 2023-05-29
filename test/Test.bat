echo("Expected output: 1,Rossi,Fabio,01/06/1990;")
dotnet run --project ../Search.csproj ../file.csv 1 Rossi
echo("Expected output: 2,Gialli,Alessandro,02/07/1989;")
dotnet run --project ../Search.csproj ../file.csv 1 Gialli
echo("Expected output: 3,Verdi,Alberto,03/08/1987;")
dotnet run --project ../Search.csproj ../file.csv 1 Verdi
echo("Expected output: 1,Rossi,Fabio,01/06/1990;")
dotnet run --project ../Search.csproj ../file.csv 2 Fabio
echo("Expected output: 2,Gialli,Alessandro,02/07/1989;")
dotnet run --project ../Search.csproj ../file.csv 2 Alessandro
echo("Expected output: 3,Verdi,Alberto,03/08/1987;")
dotnet run --project ../Search.csproj ../file.csv 2 Alberto