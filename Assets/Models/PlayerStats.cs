/// <summary>
/// Характеристики персонажа
/// </summary>
public struct PlayerStats 
{
    /// <summary>
    /// Здоровье
    /// </summary>
    public int Vitality { get => _vitality; set => _vitality = value; }

    /// <summary>
    /// Выносливость
    /// </summary>
    public int Endurance { get => _endurance; set => _endurance = value; }

    /// <summary>
    /// Сила
    /// </summary>
    public int Strength { get => _strength; set => _strength = value; }

    /// <summary>
    /// Ловкость
    /// </summary>
    public int Dexterity { get => _dexterity; set => _dexterity = value; }

    /// <summary>
    /// Интеллект
    /// </summary>
    public int Intelligence { get => _intelligence; set => _intelligence = value; }

    /// <summary>
    /// Колдовство
    /// </summary>
    public int Witchery { get => _witchery; set => _witchery = value; }

    /// <summary>
    /// Максимальное здоровье
    /// </summary>
    public int MaxHealth { get => _maxhealth; set => _maxhealth = value; }

    /// <summary>
    /// Максимальная выносливость
    /// </summary>
    public int MaxStamina { get => _maxstamina; set => _maxstamina = value; }

    /// <summary>
    /// Скорость
    /// </summary>
    public float Speed { get => _speed; set => _speed = value; }

    private int _vitality;
    private int _endurance;
    private int _strength;
    private int _dexterity;
    private int _intelligence;
    private int _witchery;
    private int _maxhealth;
    private int _maxstamina;
    private float _speed;
}
