/// <summary>
/// �������� ��������� �����
/// </summary>
public interface IBuff
{
    /// <summary>
    /// ���������� �����
    /// </summary>
    /// <param name="stats"></param>
    /// <returns></returns>
    public PlayerStats ApplyBuff(PlayerStats stats);
}
