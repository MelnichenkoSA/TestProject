using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// ���������� ������
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// ������� ������� �����
    /// </summary>
    public Action<IBuff> BuffAction;

    /// <summary>
    /// ������� ���������� ��������
    /// </summary>
    public Action UpdateSpeedAction;

    /// <summary>
    /// ������� ��������� � ���� ��������� ����
    /// </summary>
    public Action<int> InDamageZoneAction;

    /// <summary>
    /// ������� ������ �� ���� ��������� ����
    /// </summary>
    public Action OutDamageZoneAction;
    private Player _player;
    private Camera _camera;
    private NavMeshAgent _agent;
    private Coroutine _damagePerSecondCoroutine;

    public Player Player { get => _player;}

    void Start()
    {
        Init(new Player());
        _camera = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
        BuffAction += Player.AddBuff;
        UpdateSpeedAction += UpdateSpeed;

        InDamageZoneAction += StayInDamageZone;
        OutDamageZoneAction += ExitOutDamageZone;

        _agent.speed = Player.Speed;
        Debug.Log($"����� ������. ��������: {Player.CurrentStats.Speed}");
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
        _agent.speed = Player.Speed;
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
        while (Player.Health > 0)
        {
            Player.Health -= damagePerSecond;

            Debug.Log("Health: " + Player.Health);

            yield return new WaitForSeconds(1);
        }

        yield break;
    }
}
