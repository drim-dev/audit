namespace Audit.Model;

/// <summary>
/// Способ платежа
/// </summary>
internal class PaymentType
{
    /// <summary>
    /// Наименование способа платежа
    /// </summary>
    public required string Name { get; set; }
}
