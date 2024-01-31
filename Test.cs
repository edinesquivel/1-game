using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int playerHealth;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //this code runs once when the game start.
        rb = GetComponent<Rigidbody2D>() ;
        Debug.Log("Hello, i'm here!");
    }

    // Update is called once per frame
    void Update()
    {
        // your game logic
    }


    void Awake()
    {
        playerHealth = 100;
    }
    void fixedUpdate()
    {
        // physics related code
    }
}
