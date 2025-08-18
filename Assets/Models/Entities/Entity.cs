using UnityEngine;

/// <summary>
/// Основной класс для существ
/// </summary>
public class Entity : ScriptableObject
{
    protected int id;
    protected int health;
    protected string title;
    protected float speed;

    /// <summary>
    /// Метод передвижения
    /// </summary>
    public virtual void Move()
    {

    }
}
