using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
       
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed*Time.fixedDeltaTime);
    }
}
