namespace Lab3;
/// <summary>
/// Класс исключения
/// </summary>
public class TempException : Exception
{
    /// <summary>
    /// Свойство, которое обозначает время возникновения исключения
    /// </summary>
    public DateTime ErrorTimeStamp { get; set; }
    /// <summary>
    /// Причина исключения
    /// </summary>
    public string CauseOfError { get; set; }
    /// <summary>
    /// Конструкторы
    /// </summary>
    public TempException(){}

    public TempException(string message, string cause, DateTime time)
    :base(message)
    {
        CauseOfError = cause;
        ErrorTimeStamp = time;
    }
}