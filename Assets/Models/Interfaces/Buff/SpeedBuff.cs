using UnityEngine;

/// <summary>
/// Бафф на скорость
/// </summary>
public class SpeedBuff : IBuff
{
    private float _speedBonus;

    public SpeedBuff(float speedBonus)
    { 
        _speedBonus = speedBonus; 
    }

    /// <summary>
    /// Применение баффа
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
