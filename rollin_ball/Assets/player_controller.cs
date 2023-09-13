using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float intensity = 5.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(intensity * Input.GetAxis("Horizontal"), 0, intensity * Input.GetAxis("Vertical"));
    }
}
