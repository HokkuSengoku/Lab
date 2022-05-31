namespace Lab3;
/// <summary>
/// Интерфейс отопления.
/// </summary>
public interface IHeating
{
    /// <summary>
    /// Наименование источника отопления.
    /// </summary>
    public string HeatName { get; set; }
    /// <summary>
    /// Температура/Мощность источника отопления
    /// </summary>
    public double HeatTempC { get; set; }
    /// <summary>
    /// Метод изменения температуры в '+' сторону.
    /// </summary>
    /// <param name="heatup"></param>
    /// <returns></returns>
    public double HeatUp(double heatup);
    /// <summary>
    /// Метод изменения температуры в '-' сторону.
    /// </summary>
    /// <param name="heatdown"></param>
    /// <returns></returns>
    public double HeadDown(double heatdown);
}