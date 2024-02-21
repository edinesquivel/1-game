using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int playerHealth;
    public float jumpForce = 10f; // Adjust this value to control jump force
    Rigidbody2D rb; // Use Rigidbody2D for 2D physics

    // Start is called before the first frame update
    void Start()
    {
        // This code runs once when the game starts.
        rb = GetComponent<Rigidbody2D>(); // Use GetComponent<Rigidbody2D>() for 2D physics
        Debug.Log("Hello, I'm here!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        // Your game logic
    }

    void Awake()
    {
        playerHealth = 100;
        // Use GetComponent<Rigidbody2D>() for 2D physics
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Use Vector2.up for 2D physics
        rb.AddForce(Vector2.up * jumpForce);
    }
}