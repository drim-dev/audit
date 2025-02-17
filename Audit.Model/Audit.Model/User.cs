namespace Audit.Model;

/// <summary>
/// Пользователь системы
/// </summary>
internal class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Логин/Имя пользователя
    /// </summary>
    public required User UserName { get; set; }

    /// <summary>
    /// ФИО пользователя
    /// </summary>
    public required User Name { get; set; }
}
