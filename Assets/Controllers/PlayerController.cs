using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Контроллер игрока
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Событие подбора баффа
    /// </summary>
    public Action<IBuff> BuffAction;

    /// <summary>
    /// Событие обновления скорости
    /// </summary>
    public Action UpdateSpeedAction;

    /// <summary>
    /// Событие попадания в зону наносящую урон
    /// </summary>
    public Action<int> InDamageZoneAction;

    /// <summary>
    /// Событие выхода из зоны наносящей урон
    /// </summary>
    public Action OutDamageZoneAction;
    private Player _player;
    private Camera _camera;
    private NavMeshAgent _agent;
    private Coroutine _damagePerSecondCoroutine;
    void Start()
    {
        Init(new Player());
        _camera = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
        BuffAction += _player.AddBuff;
        UpdateSpeedAction += UpdateSpeed;

        InDamageZoneAction += StayInDamageZone;
        OutDamageZoneAction += ExitOutDamageZone;

        _agent.speed = _player.Speed;
        Debug.Log($"Игрок создан. Скорость: {_player.CurrentStats.Speed}");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }

    private void Init(Player player)
    {
        _player = player;
    }

    private void UpdateSpeed()
    {
        _agent.speed = _player.Speed;
    }
    private void StayInDamageZone(int damagePersecond)
    {
        if (_damagePerSecondCoroutine != null)
        {
            StopCoroutine(_damagePerSecondCoroutine);
        }

        _damagePerSecondCoroutine = StartCoroutine(Damaging(damagePersecond));

        Debug.Log("StartDamage");
    }

    private void ExitOutDamageZone()
    {
        if (_damagePerSecondCoroutine != null)
        {
            StopCoroutine (_damagePerSecondCoroutine);
            _damagePerSecondCoroutine = null;
        }

        Debug.Log("StopDamage");
    }

    IEnumerator Damaging(int damagePerSecond)
    {
        while (_player.Health > 0)
        {
            _player.Health -= damagePerSecond;

            Debug.Log("Health: " + _player.Health);

            yield return new WaitForSeconds(1);
        }

        yield break;
    }
}
