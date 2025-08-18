/// <summary>
/// ������
/// </summary>
public class Weapon : InventoryItem, IBlockable
{
    /// <summary>
    /// ���������� ����
    /// </summary>
    public int Damage { get => _damage; set => _damage = value; }

    /// <summary>
    /// ���� �� ����
    /// </summary>
    public int DamageFire { get => _damageFire; set => _damageFire = value; }

    /// <summary>
    /// ���� �� ������
    /// </summary>
    public int DamageLightning { get => _damageLightning; set => _damageLightning = value; }

    /// <summary>
    /// ���� �� �����
    /// </summary>
    public int DamageMagic { get => _damageMagic; set => _damageMagic = value; }

    /// <summary>
    /// ������ �� ����������� �����
    /// </summary>
    public int BlockDamage { get => _blockDamage; set => _blockDamage = value; }

    /// <summary>
    /// ������ �� ����
    /// </summary>
    public int BlockFire { get => _blockFire; set => _blockFire = value; }
    
    /// <summary>
    /// ������ �� ������
    /// </summary>
    public int BlockLightning { get => _blockLightning; set => _blockLightning = value; }

    /// <summary>
    /// ������ �� �����
    /// </summary>
    public int BlockMagic { get => _blockMagic; set => _blockMagic = value; }

    /// <summary>
    /// ��������� ���
    /// </summary>
    public int StatusPoison { get => _statusPoison; set => _statusPoison = value; }

    /// <summary>
    /// ��������� ������������
    /// </summary>
    public int StatusBleed { get => _statusBleed; set => _statusBleed = value; }

    /// <summary>
    /// ������� ������ ������������
    /// </summary>
    public int BaseStaminaCost { get => _baseStaminaCost; set => _baseStaminaCost = value; }

    /// <summary>
    /// ���������� ����
    /// </summary>
    public int RequireStrength { get => _requireStrength; set => _requireStrength = value; }
    
    /// <summary>
    /// ���������� ��������
    /// </summary>
    public int RequireDexterity { get => _requireDexterity; set => _requireDexterity = value; }

    /// <summary>
    /// ���������� ����������
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
