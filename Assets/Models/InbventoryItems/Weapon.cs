/// <summary>
/// Оружие
/// </summary>
public class Weapon : InventoryItem, IBlockable
{
    /// <summary>
    /// Физический урон
    /// </summary>
    public int Damage { get => _damage; set => _damage = value; }

    /// <summary>
    /// Урон от огня
    /// </summary>
    public int DamageFire { get => _damageFire; set => _damageFire = value; }

    /// <summary>
    /// Урон от молний
    /// </summary>
    public int DamageLightning { get => _damageLightning; set => _damageLightning = value; }

    /// <summary>
    /// Урон от магии
    /// </summary>
    public int DamageMagic { get => _damageMagic; set => _damageMagic = value; }

    /// <summary>
    /// Защита от физического урона
    /// </summary>
    public int BlockDamage { get => _blockDamage; set => _blockDamage = value; }

    /// <summary>
    /// Защита от огня
    /// </summary>
    public int BlockFire { get => _blockFire; set => _blockFire = value; }
    
    /// <summary>
    /// Защита от молний
    /// </summary>
    public int BlockLightning { get => _blockLightning; set => _blockLightning = value; }

    /// <summary>
    /// Защита от магии
    /// </summary>
    public int BlockMagic { get => _blockMagic; set => _blockMagic = value; }

    /// <summary>
    /// Наложение яда
    /// </summary>
    public int StatusPoison { get => _statusPoison; set => _statusPoison = value; }

    /// <summary>
    /// Наложение кровотечения
    /// </summary>
    public int StatusBleed { get => _statusBleed; set => _statusBleed = value; }

    /// <summary>
    /// Базовый расход выносливости
    /// </summary>
    public int BaseStaminaCost { get => _baseStaminaCost; set => _baseStaminaCost = value; }

    /// <summary>
    /// Требование силы
    /// </summary>
    public int RequireStrength { get => _requireStrength; set => _requireStrength = value; }
    
    /// <summary>
    /// Требование ловкости
    /// </summary>
    public int RequireDexterity { get => _requireDexterity; set => _requireDexterity = value; }

    /// <summary>
    /// Требование интеллекта
    /// </summary>
    public int RequireInteIntelligence { get => _requireInteIntelligence; set => _requireInteIntelligence = value; }

    protected int _damage;
    protected int _damageFire;
    protected int _damageLightning;
    protected int _damageMagic;
    protected int _blockDamage;
    protected int _blockFire;
    protected int _blockLightning;
    protected int _blockMagic;
    protected int _statusPoison;
    protected int _statusBleed;
    protected int _baseStaminaCost;
    protected int _requireStrength;
    protected int _requireDexterity;
    protected int _requireInteIntelligence;
}
