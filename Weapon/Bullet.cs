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

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Hit_Enemy enemy = hitInfo.GetComponent<Hit_Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        if (hitInfo.CompareTag("Out"))
        {
            Destroy(gameObject);
        }
        //Debug.Log(hitInfo.name);
        
    }
}
