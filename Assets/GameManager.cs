using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ------------------
    // Start Screen buttons
    // ------------------
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShowInfo()
    {
        // enable info panel here
        Debug.Log("info button clicked! show instructions panel here.");
        // example:
        // infoPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game clicked");
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("EndScene");
    }
}
