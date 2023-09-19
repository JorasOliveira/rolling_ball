using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);
    }
}
