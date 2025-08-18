using UnityEngine;

/// <summary>
/// ���� �� ��������
/// </summary>
public class SpeedBuff : IBuff
{
    private float _speedBonus;

    public SpeedBuff(float speedBonus)
    { 
        _speedBonus = speedBonus; 
    }

    /// <summary>
    /// ���������� �����
    /// </summary>
    /// <param name="stats"></param>
    /// <returns></returns>
    public PlayerStats ApplyBuff(PlayerStats stats)
    {
        PlayerStats newStats = stats;
        newStats.Speed = Mathf.Max(newStats.Speed + _speedBonus, 1);

        return newStats;
    }

}
