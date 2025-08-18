/// <summary>
/// Броня
/// </summary>
public class Armor : InventoryItem, IBlockable
{
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

    protected int _blockDamage;
    protected int _blockFire;
    protected int _blockLightning;
    protected int _blockMagic;

}
