namespace Lab3;

public class Otherroom : Room
{
    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="season">Сезон года</param>
    /// <param name="rname">Название помещения</param>
    /// <param name="rsquare">Площадь</param>
    /// <param name="roomtemp">Температура в помещении</param>
    public Otherroom(Season season, string rname, double rsquare, double roomtemp):base(season, rname, rsquare, roomtemp){}

    /// <summary>
    /// Вложенный класс TempBoosting
    /// </summary>
    /// <param name="parent"> Включающий класс(экземпляр включающего класса)</param>
    /// <param name="_tempOverBoost">Максимальное значение температуры</param>
    public class TempBoosting
    {
        private Otherroom parent =  new Otherroom(Season.Winter,"Большой зал", 150.1, 24);
        private double _tempOverBoost = Double.MaxValue;
        
        /// <summary>
        /// Конструкторы вложенного класса
        /// </summary>
        public TempBoosting(){}
        public TempBoosting(Otherroom parent)
        {
            this.parent = parent;
        }
        
/// <summary>
/// Метод повышения температуры с проверкой переполнения
/// </summary>
/// <exception cref="TempException">Вызывается при переполнении</exception>
        public void ExtraTempChecked()
        {
            try
            {
                parent.RoomTempC = checked(_tempOverBoost + parent.RoomTempC);
                throw new TempException("Исключение связанное с температурой", "Превышена допустимая температура",
                    DateTime.Now);
            }
            catch (TempException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
                Console.WriteLine(e.CauseOfError);
                Console.WriteLine(e.ErrorTimeStamp.ToString());
            }
        }

/// <summary>
/// Метод повышения температуры без проверки переполнения
/// </summary>
        public void ExtraTempUnchecked()
        {
            parent.RoomTempC = _tempOverBoost + parent.RoomTempC;
            Console.WriteLine($"Температура после максимального повышения температуры без проверки: = {parent.RoomTempC}");
        }
    }
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
    /// <summary>
    /// Переопределенный метод сравнения объектов.
    /// </summary>
    /// <param name="obj">Принимает в качестве аргумента объект</param>
    /// <returns>Возвращает результат сравнения объектов true/false</returns>
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
    /// <summary>
    /// Возвращает строку, представляющую текущий объект, в данном случае всю информацию о текущем экземпляре класса.
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Получение хеш-кода названия помещения.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode() => RoomName.GetHashCode();

}