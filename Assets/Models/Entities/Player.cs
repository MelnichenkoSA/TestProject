using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс игрока
/// </summary>
public class Player : Entity, IBuffable
{
    /// <summary>
    /// Уровень игрока
    /// </summary>
    public int Lvl { get => _lvl; set => _lvl = value; }

    /// <summary>
    /// Монеты игрока
    /// </summary>
    public int Coins { get => _coins; set => _coins = value; }

    /// <summary>
    /// ID игрока
    /// </summary>
    public int ID { get => id; set => id = value; }

    /// <summary>
    /// Текущее здоровье игрока
    /// </summary>
    public int Health { get => health; set => health = value; }

    /// <summary>
    /// Скорость игрока
    /// </summary>
    public float Speed { get => CurrentStats.Speed;}

    /// <summary>
    /// Имя игрока
    /// </summary>
    public string Name { get => title; set => title = value; }

    /// <summary>
    /// Характеристики игрока без баффов
    /// </summary>
    public PlayerStats BaseStats { get => _baseStats; set => _baseStats = value; }

    /// <summary>
    /// Характеристики игрока с баффами
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
    /// Добавление баффа
    /// </summary>
    /// <param name="buff"></param>
    public void AddBuff(IBuff buff)
    {
        _buffs.Add(buff);

        ApplyBuffs();

        Debug.Log("Бафф получен");
    }

    /// <summary>
    /// Удаление баффа
    /// </summary>
    /// <param name="buff"></param>
    public void RemoveBuff(IBuff buff)
    {
        _buffs.Remove(buff);

        ApplyBuffs();

        Debug.Log("Бафф удалён");
    }


    /// <summary>
    /// Применение баффов
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
