using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 20f;
    [SerializeField] private int damage = 20;
    private Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * bulletSpeed;
    }

    private void Update()
    {
        if(transform.position.magnitude > 10f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
