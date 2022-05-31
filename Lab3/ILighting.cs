namespace Lab3;
/// <summary>
/// Интерфейс освещения.
/// </summary>
public interface ILighting
{
    /// <summary>
    /// Наименование источника освещения.
    /// </summary>
    public string LightName { get; set; }
    /// <summary>
    /// Значение мощности источника освещения.
    /// </summary>
    public int LightPow { get; set; }
    /// <summary>
    /// Метод, предоставляющий информацию об источнике освещения и его мощности.
    /// </summary>
    public void LightInfo();
}