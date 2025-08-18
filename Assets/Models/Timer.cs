using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// ����� ������ ��� ��������� ������
/// </summary>
public class Timer : MonoBehaviour
{
    /// <summary>
    /// ������� ������ �������
    /// </summary>
    public int Seconds { get => _seconds; set => _seconds = value; }

    /// <summary>
    /// ������� ���������� �������
    /// </summary>
    public event Action Completed;
    private int _seconds;

    public static Timer Create
    {
        get
        {
            var go = new GameObject("[Timer]");
            var timer = go.AddComponent<Timer>();

            return timer;
        }
    }

    /// <summary>
    /// ������ �������
    /// </summary>
    /// <param name="seconds"></param>
    public void StartTimer(int seconds)
    {
        StartCoroutine(TimerCourutine(seconds));
    }

    IEnumerator TimerCourutine(int seconds)
    {
        while (seconds > 0)
        {
            seconds--;

            yield return new WaitForSeconds(1);
        }
        Completed?.Invoke();
        Completed = null;
        Destroy(gameObject);
    }

}
