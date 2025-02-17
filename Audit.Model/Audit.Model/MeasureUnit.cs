namespace Audit.Model;

/// <summary>
/// Единица измерения
/// </summary>
internal class MeasureUnit : BaseEntity
{
    /// <summary>
    /// Наименование единицы измерения
    /// </summary>
    public required string Name { get; set; }
}
