using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1 : MonoBehaviour
{


    //Drag in the Alien Prefab from the Component Inspector.
    public GameObject Alien;
    private float timer;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Alien_Forward_Force;
    public RocketMovement rocket;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(Random.Range(0f, 1f), 1));

        GameObject Temporary_Alien_Handler;

        timer += Time.deltaTime;
        if (rocket.dead == false)
        {
            if (timer > 3f)
            {
                Temporary_Alien_Handler = Instantiate(Alien, pos, Quaternion.identity) as GameObject;

                Rigidbody2D Temporary_RigidBody;
                Temporary_RigidBody = Temporary_Alien_Handler.GetComponent<Rigidbody2D>();


                Temporary_RigidBody.AddForce(transform.up * Alien_Forward_Force);

                timer = 0;
                Destroy(Temporary_Alien_Handler, 7.0f);
            }
        }

    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            Destroy(gameObject);

        }
    }
}
