using Lab3;
var room = new Otherroom(Season.Winter,"Большой зал", 150.1, 50);
var botroom = new Otherroom(Season.Winter,"Большой зал", 150.1, 501);

Console.WriteLine($"room.ToString = {room.ToString()}");
Console.WriteLine($"botroom.ToString = {botroom.ToString()}");
Console.WriteLine($"room = bootroom?: {room.Equals(botroom)}");
Console.WriteLine($"Same hash codes?: {room.GetHashCode() == botroom.GetHashCode()}");