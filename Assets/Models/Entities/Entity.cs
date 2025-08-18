using UnityEngine;

/// <summary>
/// �������� ����� ��� �������
/// </summary>
public class Entity : ScriptableObject
{
    protected int id;
    protected int health;
    protected string title;
    protected float speed;

    /// <summary>
    /// ����� ������������
    /// </summary>
    public virtual void Move()
    {

    }
}
