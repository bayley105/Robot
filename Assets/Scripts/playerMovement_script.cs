using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_script : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    Vector2 velocity;

    public float runSpeed;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        body.velocity = velocity;
    }
}
