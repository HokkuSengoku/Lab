namespace Lab3;

public class Otherroom : Room
{
    public Otherroom(Season season, string rname, double rsquare, double roomtemp):base(season, rname, rsquare, roomtemp){}
    
    public override void CheckRoomLighting(ILighting light)
    {
        if (RoomSquare < 150)
        {
            LightName = "Fireplace";
            LightPow = 500;
        } 
        else if (RoomSquare > 150)
        {
            LightName = "One Fireplace and One Chandelier";
            LightPow = 3500;
        }
    }
    
    public override void CheckRoomTemp()
    {
        
        if (RoomTempC < SeasonTC)
        {
            do
            {
                RoomTempC += HeatUp(1);
            } while (RoomTempC < SeasonTC);
        }

        else if (RoomTempC > SeasonTC)
        {
            do
            {
                RoomTempC -= HeadDown(1);
            } while (RoomTempC > SeasonTC);
        }
    }

    public override double HeadDown(double heattempC)
    {
        return heattempC;
    }

    public override double HeatUp(double heattempC)
    {
        return heattempC;
    }

    public override void LightInfo()
    {
        Console.WriteLine($"Для освещения использовалось: {LightName} \n" +
                          $"Мощность освещения: {LightPow} \n");
    }

    public override void GiveRoomInfo()
    {
        Console.WriteLine($"Информация о помещении.\n" +
                          $"Название помещения: {RoomName} \n" +
                          $"Площадь помещения: {RoomSquare} \n" +
                          $"Рекомендуемая мощность освещения: {RoomNeedLPower} Лк.\n" +
                          $"Рекомендуемая температура: 20-25 градусов Цельсия \n" +
                          $"*****Освещение:\n" +
                          $"Для освещения использовалось: {LightName} \n" +
                          $"Мощность освещения: {LightPow} \n" +
                          $"***** Температура в помещении: \n" +
                          $"Температура после изменений: {RoomTempC}");
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Otherroom temp))
        {
            return false;
        }

        if (temp.HeatName == this.HeatName
            && temp.LightName == this.LightName
            && temp.LightPow == this.LightPow
            && temp.RoomName == this.RoomName
            && temp.RoomSquare == this.RoomSquare
            && temp.HeatTempC == this.HeatTempC
            && temp.RoomTempC == this.RoomTempC
            && temp.SeasonST == this.SeasonST
            && temp.SeasonTC == this.SeasonTC
            && temp.RoomNeedLPower == this.RoomNeedLPower)
        {
            return true;
        }

        return false;
    }
    
    public override string ToString() => $"Информация о помещении.\n" +
                                         $"Название помещения: {RoomName} \n" +
                                         $"Площадь помещения: {RoomSquare} \n" +
                                         $"Рекомендуемая мощность освещения: {RoomNeedLPower} Лк.\n" +
                                         $"Рекомендуемая температура: 20-25 градусов Цельсия \n" +
                                         $"*****Освещение:\n" +
                                         $"Для освещения использовалось: {LightName} \n" +
                                         $"Мощность освещения: {LightPow} \n" +
                                         $"***** Температура в помещении: \n" +
                                         $"Температура после изменений: {RoomTempC}";

    public override int GetHashCode() => RoomName.GetHashCode();

}