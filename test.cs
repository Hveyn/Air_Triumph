using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private float speedRotation = 0.5f;
    private GameObject playerTarget;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = playerTarget.transform.position - transform.position;
        Quaternion rotation = Quaternion.FromToRotation(transform.position, direction);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speedRotation*Time.deltaTime);

    }
}
