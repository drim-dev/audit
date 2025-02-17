namespace Audit.Model;

internal class BaseEntity
{
    /// <summary>
    /// Идентификатор сущности
    /// </summary>
    public virtual int Id { get; set; }

    /// <summary>
    /// Дата создания сущности
    /// </summary>
    public DateTime DateOfCreated { get; set; }

    /// <summary>
    /// Пользователь, создавший сущность
    /// </summary>
    public required User CreatedByUserId { get; set; }

    /// <summary>
    /// Флаг удаления записи
    /// </summary>
    public bool IsDeleted { get; set; }
}
