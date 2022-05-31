namespace Lab3;
/// <summary>
/// Абстрактный класс помещения, который реализует интерфейсы ILightung и IHeating.
/// </summary>
public abstract class Room : ILighting, IHeating
{
    /// <summary>
    /// Название помещения.
    /// </summary>
    public string RoomName { get;  }
    /// <summary>
    /// Площадь помещения.
    /// </summary>
    public double RoomSquare { get; set;}
    /// <summary>
    /// Рекомендуемая мощность освещения для помещения.
    /// </summary>
    public double RoomNeedLPower { get; set; }
    /// <summary>
    /// Температура в помещении.
    /// </summary>
    public double RoomTempC { get; set; }
    /// <summary>
    /// Сезон года.
    /// </summary>
    public string SeasonST { get; set; }
    /// <summary>
    /// Рекомендуемая температура в конкретный сезон года для помещения.
    /// </summary>
    public double SeasonTC { get; set; }
    
    protected Room(Season season,string rname = "DefName", double rsquare = 0, double roomtemp = 15)
    {
        RoomName = rname;
        RoomSquare = rsquare;
        RoomNeedLPower = rsquare * 150;
        RoomTempC = roomtemp;
        SeasonTC = (double)season;
    }
    /// <summary>
    /// Метод, получающий информацию об мощности и типе освещения.
    /// </summary>
    /// <param name="light"></param>
    public abstract void CheckRoomLighting(ILighting light);
    /// <summary>
    /// Метод, получающий информацию об температуре в помещении и изменяющий её на основе температуры сезона года.
    /// </summary>
    public abstract void CheckRoomTemp();
    /// <summary>
    /// Метод, предоставляющий полную информацию об помещении.
    /// </summary>
    public abstract void GiveRoomInfo();

    #region ILighting Members
    ///<inheritdoc />
    public string LightName { get; set; }
    public int LightPow { get; set; }
    public abstract void LightInfo();
    #endregion

    #region IHeat Members
    ///<inheritdoc />
    public string HeatName { get; set; }
    public double HeatTempC { get; set; }
    public abstract double HeatUp(double heattempC);
    public abstract double HeadDown(double heattempC);
    #endregion

    ///<inheritdoc />
    public abstract bool Equals(object obj);
    ///<inheritdoc />
    public abstract int GetHashCode();
    ///<inheritdoc />
    public abstract string ToString();
}