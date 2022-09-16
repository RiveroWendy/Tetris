using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
        
    }

    public void LoadTetris()
    {
        SceneManager.LoadScene("Tetris");
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void ExitGame()
    {
        Application.Quit();

    }
}
