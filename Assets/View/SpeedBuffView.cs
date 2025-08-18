using UnityEngine;

/// <summary>
/// Класс баффа, который находится на уровне
/// </summary>
public class SpeedBuffView : MonoBehaviour
{
    private TempBuff _tempSpeedBuff;
    private PlayerController playerController;
    private GameObject _speedBuff;
    private Player _player;
    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        _player = FindObjectOfType<Player>();
        _speedBuff = gameObject;
    }

    /// <summary>
    /// Подбор баффа игроком
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            _tempSpeedBuff = new TempBuff(playerController, _player, new SpeedBuff(3), 3);

            playerController.BuffAction.Invoke(_tempSpeedBuff);
            playerController.UpdateSpeedAction.Invoke();
            Destroy(_speedBuff);
        }
    }
}
