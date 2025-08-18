using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// ���������� ��� �������� ����
/// </summary>
public class MainMenuController : MonoBehaviour
{
    /// <summary>
    /// ������ ����� ����
    /// </summary>
    public Button NewGameButton;

    /// <summary>
    /// ������ ����������� ���� (�� ��������)
    /// </summary>
    public Button ContinueGameButton;

    /// <summary>
    /// ������ ������ �� ����
    /// </summary>
    public Button QuitButton;

    private void Awake()
    {
        NewGameButton.onClick.AddListener(StartNewGame);
        ContinueGameButton.onClick.AddListener(ContinueGame);
        QuitButton.onClick.AddListener(CloseGame);
    }
    private void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
    private void ContinueGame()
    {
        SceneManager.LoadScene(1);
    }
    private void CloseGame()
    {
        Application.Quit();
    }
}
