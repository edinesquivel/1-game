using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control movement speed
    public float jumpForce = 10f; // Adjust this value to control jump force
    private bool isGrounded; // Check if the player is on the ground

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true; // Assuming the player starts on the ground
    }
    void Awake(){
        string [] list = { "welcome","this game is a adventure game","players will have to get to the end to win"};
        for(int i = 0; i<list.Length;i++){
            Debug.Log(list[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jumpForce);
        isGrounded = false; // Player is no longer on the ground after jumping
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player has landed on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}