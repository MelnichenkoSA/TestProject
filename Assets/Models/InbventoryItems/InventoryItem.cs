using UnityEngine;

/// <summary>
/// Предмет инвентаря
/// </summary>
[CreateAssetMenu(fileName = "InventoryItem", menuName = "InventoryItems/DefaultInventoryItem")]
public class InventoryItem : ScriptableObject
{
    public int Id
    {
        get => _id;
        set => _id = value;
    }
    public int Cost
    {
        get => _cost;
        set => _cost = value;
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public string Description
    {
        get => _description;
        set => _description = value;
    }

    protected int _id = 0;
    protected int _cost = 0;
    protected string _name = "default_name";
    protected string _description = "default_description";
}
