using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcontrol : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private float speed;
    
    void FixedUpdate()
    {
        transform.Translate(direction*Time.deltaTime*speed);
    }
    
}
