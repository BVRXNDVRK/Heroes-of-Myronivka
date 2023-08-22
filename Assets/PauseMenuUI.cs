using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour
{
    
    public static bool GameIsPaused = false;
    public GameObject PauseMenu;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused) {
                PauseResume();
            } else {
                Pause();
            }
        }
    }

    public void Pause() {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void PauseResume() {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PauseRestart() {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void PauseExit() {
        Application.Quit();
    }
}
