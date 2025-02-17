namespace Audit.Model;

/// <summary>
/// Товар заказа
/// </summary>
internal class Product : BaseEntity
{
    /// <summary>
    /// Артикул товара
    /// </summary>
    public required string Article { get; set; }

    /// <summary>
    /// Наименование товара
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Количество товара
    /// </summary>
    public decimal Count { get; set; }

    /// <summary>
    /// Скидка, %
    /// </summary>
    public byte Discount { get; set; }

    /// <summary>
    /// Цена закупа
    /// </summary>
    public decimal? PurchasePrice { get; set; }

    /// <summary>
    /// Цена продажи
    /// </summary>
    public decimal SelePrice { get; set; }

    /// <summary>
    /// Идентификатор единицы измерения
    /// </summary>
    public int MeasureUnitId { get; set; }

    /// <summary>
    /// Единица измерения
    /// </summary>
    public required MeasureUnit MeasureUnit { get; set; }

    /// <summary>
    /// Идентификатор изделия
    /// </summary>
    public int OrderInstanceId { get; set; }

    /// <summary>
    /// Изделие
    /// </summary>
    public required OrderInstance OrderInstance { get; set; }
}
