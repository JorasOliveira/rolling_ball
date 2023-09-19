using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{
    // Create public variables for player speed, and for the Text UI game objects
	public TextMeshProUGUI countText;
	public GameObject winTextObject;
    private int count;
    public float intensity = 7.0f;
    public Rigidbody rb;
    public float fallThreshold = 1.0f; // Adjust this threshold as needed

    // Start is called before the first frame update
	void Start ()
	{
		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody>();
		// Set the count to zero 
		count = 0;

		SetCountText ();
        // Set the text property of the Win Text UI to an empty string, making the 'You Win' (game over message) blank
        winTextObject.SetActive(false);
	}
    // Check the current scene name and enable/disable input accordingly
   
    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(intensity * Input.GetAxis("Horizontal"), 0, intensity * Input.GetAxis("Vertical"));
        // Check if the Y-velocity is below the threshold (falling)
        if (rb.velocity.y < -fallThreshold)
        {
            SceneManager.LoadScene(1);
        }

        
    }

	void OnTriggerEnter(Collider other) 
	{
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("pickUp"))
		{
			other.gameObject.SetActive (false);

			// Add one to the score variable 'count'
			count = count + 1;

			// Run the 'SetCountText()' function (see below)
			SetCountText ();
		}
	}

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12) 
        {
            // Set the text value of your 'winText'
            winTextObject.SetActive(true);
            SceneManager.LoadScene(2);
        }
    }

}






