namespace Audit.Model;

/// <summary>
/// Точка продаж
/// </summary>
internal class PointOfSale : BaseEntity
{
    /// <summary>
    /// Наименование точки продаж
    /// </summary>
    public required string Name { get; set; }
}
