namespace Lab3;

public interface ILighting
{
    public string LightName { get; set; }
    public int LightPow { get; set; }
    public void LightInfo();
}