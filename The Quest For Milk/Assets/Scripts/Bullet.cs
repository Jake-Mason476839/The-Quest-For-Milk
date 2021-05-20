using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Rigidbody2D bullet;
    public Transform bulletSpawn;

    public void Fire()
    {
        Rigidbody2D bulletClone = (Rigidbody2D) Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.forward * bulletSpeed;
    }
}
