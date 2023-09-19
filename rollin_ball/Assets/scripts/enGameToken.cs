
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGameToken: MonoBehaviour
{
    // This function is called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or object
        // You can customize this condition based on your game's requirements
        if (collision.gameObject.CompareTag("Player"))
        {
           SceneManager.LoadScene(3);
        }
    }
}