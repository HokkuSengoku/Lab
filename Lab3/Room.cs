namespace Lab3;

public abstract class Room : ILighting, IHeating
{
    public string RoomName { get;  }
    public double RoomSquare { get; set;}
    public double RoomNeedLPower { get; set; }
    public double RoomTempC { get; set; }
    public string SeasonST { get; set; }
    public double SeasonTC { get; set; }
    
    protected Room(Season season,string rname = "DefName", double rsquare = 0, double roomtemp = 15)
    {
        RoomName = rname;
        RoomSquare = rsquare;
        RoomNeedLPower = rsquare * 150;
        RoomTempC = roomtemp;
        SeasonTC = (double)season;
    }
    
    public abstract void CheckRoomLighting(ILighting light);
    public abstract void CheckRoomTemp();
    public abstract void GiveRoomInfo();

    public string LightName { get; set; }
    public int LightPow { get; set; }
    public abstract void LightInfo();

    public string HeatName { get; set; }
    public double HeatTempC { get; set; }
    public abstract double HeatUp(double heattempC);
    public abstract double HeadDown(double heattempC);

    public abstract bool Equals(object obj);
    public abstract int GetHashCode();
    public abstract string ToString();
}