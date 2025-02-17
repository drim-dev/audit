namespace Audit.Model;

/// <summary>
/// Помещение
/// </summary>
internal class Room : BaseEntity
{
    /// <summary>
    /// Наименование помещения
    /// </summary>
    public required string Name { get; set; }
}
