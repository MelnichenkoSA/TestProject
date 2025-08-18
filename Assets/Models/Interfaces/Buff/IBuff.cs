/// <summary>
/// Основной интерфейс баффа
/// </summary>
public interface IBuff
{
    /// <summary>
    /// Применение баффа
    /// </summary>
    /// <param name="stats"></param>
    /// <returns></returns>
    public PlayerStats ApplyBuff(PlayerStats stats);
}
