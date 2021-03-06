namespace Lab3;
/// <summary>
/// Класс исключения
/// </summary>
public class TempException : Exception
{
    /// <summary>
    /// Свойство, которое обозначает время возникновения исключения
    /// </summary>
    public string CauseOfError { get; set; }
    /// <summary>
    /// Конструкторы
    /// </summary>
    public TempException(){}
    public TempException(string message, string cause)
    :base(message)
    {
        CauseOfError = cause;
    }
}