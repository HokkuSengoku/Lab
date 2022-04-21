namespace Lab3;

public interface IHeating
{
    public string HeatName { get; set; }
    public double HeatTempC { get; set; }
    public double HeatUp(double heatup);
    public double HeadDown(double heatdown);
}