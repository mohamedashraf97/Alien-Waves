using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public bool dead = false;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("d"))
        {
            pos.x += 0.5f;

            transform.position = pos;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= 0.5f;

            transform.position = pos;
        }


        if (pos.x > 36.3f)
        {
            pos.x = -46;
            transform.position = pos;  // you can set the position as a whole, just not individual fields
        }
        if (pos.x < -51f)
        {
            pos.x = 32;
            transform.position = pos;  // you can set the position as a whole, just not individual fields
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Alien")
        {
            dead = true;
            //Time.timeScale = 0.0f; // to stop the game
            Debug.Log("dead1");
            Destroy(gameObject);

        }
    }
}
