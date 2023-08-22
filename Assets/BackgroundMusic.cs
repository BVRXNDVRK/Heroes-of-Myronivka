using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    void Awake() {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BackgroundMusic");

        if (musicObj.Length > 1) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
