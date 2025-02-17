namespace Audit.Model;

/// <summary>
/// Встреча
/// </summary>
internal class Meeting : Event
{
    /// <summary>
    /// Место встречи
    /// </summary>
    public required string Place { get; set; }
}
