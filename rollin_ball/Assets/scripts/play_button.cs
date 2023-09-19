using UnityEngine;
using UnityEngine.SceneManagement;

public class startScreen : MonoBehaviour
{
    public GameObject player; // Reference to your player GameObject

    void Start()
    {
        // Disable the player GameObject at the start of the game scene
        player.SetActive(false);
    }
    public void OnPlayButton ()
    {
        // player.SetActive(true);
        SceneManager.LoadScene(1);

    }
}
