namespace Lab3;
/// <summary>
/// Класс исключения
/// </summary>
public class SquareLimitException : Exception
{
    /// <summary>
    /// Свойство, которое обозначает время возникновения исключения
    /// </summary>
    public string CauseOfError { get; set; }
    /// <summary>
    /// Конструкторы
    /// </summary>
    public SquareLimitException(){}
    public SquareLimitException(string message, string cause)
        :base(message)
    {
        CauseOfError = cause;
    }
}