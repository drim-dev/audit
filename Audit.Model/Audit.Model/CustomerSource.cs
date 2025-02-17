namespace Audit.Model;

/// <summary>
/// Источник клиента
/// </summary>
internal class CustomerSource : BaseEntity
{
    /// <summary>
    /// Наименование источника
    /// </summary>
    public required string Name { get; set; }
}
