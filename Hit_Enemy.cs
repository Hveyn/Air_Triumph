using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int damage = 1;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            gameObject.SetActive(false);   
            //Destroy(gameObject);   
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        FlightPlayer player = collision.gameObject.GetComponent<FlightPlayer>();
        if(player != null)
        {
            player.hitDamage(damage);
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
        
    }

}
