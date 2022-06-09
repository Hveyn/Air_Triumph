using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int health = 5;
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

    public void hitDamage(int damage)
    {
        Debug.Log("hit");
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
