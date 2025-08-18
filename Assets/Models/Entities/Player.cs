using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����� ������
/// </summary>
public class Player : Entity, IBuffable
{
    /// <summary>
    /// ������� ������
    /// </summary>
    public int Lvl { get => _lvl; set => _lvl = value; }

    /// <summary>
    /// ������ ������
    /// </summary>
    public int Coins { get => _coins; set => _coins = value; }

    /// <summary>
    /// ID ������
    /// </summary>
    public int ID { get => id; set => id = value; }

    /// <summary>
    /// ������� �������� ������
    /// </summary>
    public int Health { get => health; set => health = value; }

    /// <summary>
    /// �������� ������
    /// </summary>
    public float Speed { get => CurrentStats.Speed;}

    /// <summary>
    /// ��� ������
    /// </summary>
    public string Name { get => title; set => title = value; }

    /// <summary>
    /// �������������� ������ ��� ������
    /// </summary>
    public PlayerStats BaseStats { get => _baseStats; set => _baseStats = value; }

    /// <summary>
    /// �������������� ������ � �������
    /// </summary>
    public PlayerStats CurrentStats { get => _currentStats; set => _currentStats = value; }

    private int _lvl;
    private int _coins;
    private PlayerStats _baseStats;
    private PlayerStats _currentStats;
    private List<IBuff> _buffs =  new();
    public Player()
    {
        PlayerStats baseStats = new PlayerStats
        {
            Vitality = 1,
            Endurance = 1,
            Strength = 1,
            Dexterity = 1,
            Intelligence = 1,
            Witchery = 1,
            MaxHealth = 100,
            MaxStamina = 100,
            Speed = 5.0f
        };
        health = 100;
        BaseStats = baseStats;
        CurrentStats = baseStats;
    }

    /// <summary>
    /// ���������� �����
    /// </summary>
    /// <param name="buff"></param>
    public void AddBuff(IBuff buff)
    {
        _buffs.Add(buff);

        ApplyBuffs();

        Debug.Log("���� �������");
    }

    /// <summary>
    /// �������� �����
    /// </summary>
    /// <param name="buff"></param>
    public void RemoveBuff(IBuff buff)
    {
        _buffs.Remove(buff);

        ApplyBuffs();

        Debug.Log("���� �����");
    }


    /// <summary>
    /// ���������� ������
    /// </summary>
    public void ApplyBuffs()
    {
        CurrentStats = BaseStats;

        foreach (IBuff buff in _buffs)
        {
            CurrentStats = buff.ApplyBuff(CurrentStats);
        }
    }
}
