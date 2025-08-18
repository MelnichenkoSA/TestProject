/// <summary>
/// �������������� ���������
/// </summary>
public struct PlayerStats 
{
    /// <summary>
    /// ��������
    /// </summary>
    public int Vitality { get => _vitality; set => _vitality = value; }

    /// <summary>
    /// ������������
    /// </summary>
    public int Endurance { get => _endurance; set => _endurance = value; }

    /// <summary>
    /// ����
    /// </summary>
    public int Strength { get => _strength; set => _strength = value; }

    /// <summary>
    /// ��������
    /// </summary>
    public int Dexterity { get => _dexterity; set => _dexterity = value; }

    /// <summary>
    /// ���������
    /// </summary>
    public int Intelligence { get => _intelligence; set => _intelligence = value; }

    /// <summary>
    /// ����������
    /// </summary>
    public int Witchery { get => _witchery; set => _witchery = value; }

    /// <summary>
    /// ������������ ��������
    /// </summary>
    public int MaxHealth { get => _maxhealth; set => _maxhealth = value; }

    /// <summary>
    /// ������������ ������������
    /// </summary>
    public int MaxStamina { get => _maxstamina; set => _maxstamina = value; }

    /// <summary>
    /// ��������
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
