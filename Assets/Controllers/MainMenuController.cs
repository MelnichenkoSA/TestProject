using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Контроллер для главного меню
/// </summary>
public class MainMenuController : MonoBehaviour
{
    /// <summary>
    /// Кнопка новой игры
    /// </summary>
    public Button NewGameButton;

    /// <summary>
    /// Кнопка продолжения игры (не работает)
    /// </summary>
    public Button ContinueGameButton;

    /// <summary>
    /// Кнопка выхода из игры
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
