using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroSelection : MonoBehaviour
{
    public void StartGameVOVA()
    {
        SceneManager.LoadScene(2);
    }

    public void StartGameVITA()
    {
        SceneManager.LoadScene(3);
    }

    public void StartGameIHOR()
    {
        SceneManager.LoadScene(4);
    }
}
