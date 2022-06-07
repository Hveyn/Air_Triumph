using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint_one;
    [SerializeField] private Transform firePoint_two;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float firerate;
    private float timeBeforeShooting;

    private void Start()
    {
        timeBeforeShooting = 1 / firerate;
    }

    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            if (timeBeforeShooting <= 0f)
            {
                Instantiate(bulletPrefab, firePoint_one.position, firePoint_one.rotation);
                Instantiate(bulletPrefab, firePoint_two.position, firePoint_two.rotation);

                timeBeforeShooting = 1 / firerate;
            }
            else
            {
                timeBeforeShooting -= Time.deltaTime;
            }
        }
        else
        {
            timeBeforeShooting = 0f;
        }
    }

   
}
