using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Enemy : MonoBehaviour
{
    [SerializeField] private float speedRotation = 0.5f;
    private GameObject playerTarget;
    private Rigidbody2D rb;


    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();   
    }
    private void Update()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = playerTarget.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        rb.rotation = angle;
        
    }
}
