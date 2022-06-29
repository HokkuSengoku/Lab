using System;
using Serilog;

using Lab3;

var room = new Otherroom(Season.Winter,"Большой зал", 150.1, 24);
var botroom = new Otherroom(Season.Winter,"Большой зал", 150.1, 501);

Console.WriteLine($"room.ToString = {room.ToString()}");
Console.WriteLine($"botroom.ToString = {botroom.ToString()}");
Console.WriteLine($"room = bootroom?: {room.Equals(botroom)}");
Console.WriteLine($"Same hash codes?: {room.GetHashCode() == botroom.GetHashCode()}");


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("C:\\Users\\Админ\\RiderProjects\\Labs\\Lab3/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
Log.Information("Логгер для информарования об исключениях и их обработке!");

try
{
    Log.Debug($"Изменение площади помещения");
    room.ChangeSquare();
}
catch (SquareLimitException m)
{
    Log.Error(m, m.CauseOfError);
}

Otherroom.TempBoosting temp = new Otherroom.TempBoosting();
try
{
    Log.Debug("Изменение температуры с арифметической проверкой");
    temp.ExtraTempChecked();
}
catch (TempException m)
{
    Log.Error(m, m.CauseOfError);

}
finally
{
    Log.CloseAndFlush();
}



