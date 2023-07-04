using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int health = 5;
    public float speed;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10);

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKeyUp(KeyCode.W))
            rb.velocity = new Vector2();

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
            rb.velocity = new Vector2();

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else if (Input.GetKeyUp(KeyCode.S))
            rb.velocity = new Vector2();

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
            rb.velocity = new Vector2();
    }
}
