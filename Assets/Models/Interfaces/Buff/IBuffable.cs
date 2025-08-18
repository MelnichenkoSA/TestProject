/// <summary>
/// Интерфейс объекта, который может принимать баффы
/// </summary>
public interface IBuffable 
{
    void AddBuff(IBuff buff);
    void RemoveBuff(IBuff buff);
}
