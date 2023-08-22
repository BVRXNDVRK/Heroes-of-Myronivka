using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeGameUI;

    public void CompleteGame() {
        completeGameUI.SetActive(true);
    }

    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("LoadCompleteGameMenu", 3f);
        }
    }

    public void RestartGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void LoadCompleteGameMenu() {
        SceneManager.LoadScene(5);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
