/// <summary>
/// Класс временного баффа
/// </summary>
public class TempBuff : IBuff
{
    private IBuffable _owner;
    private IBuff _buff;
    private int _seconds;
    private Timer _timer;
    private PlayerController _playerController;
    public TempBuff(PlayerController playercontroller, IBuffable owner, IBuff buff, int seceonds)
    {
        _playerController = playercontroller;
        _owner = owner;
        _buff = buff;
        _seconds = seceonds;
        _timer = Timer.Create;
    }

    /// <summary>
    /// Применение баффа
    /// </summary>
    /// <param name="stats"></param>
    /// <returns></returns>
    public PlayerStats ApplyBuff(PlayerStats stats)
    {
        PlayerStats newStats = _buff.ApplyBuff(stats);

        _timer.StartTimer(_seconds);
        _timer.Completed += () =>
        {
            _owner.RemoveBuff(this);
            _playerController.UpdateSpeedAction.Invoke();
        };

        return newStats;
    }
}

