using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sun_AI : MonoBehaviour
{
    public GameObject sunflowerBullet;
    public Bullet bulletScript;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Kill_Count.killCounter += 1;
            Destroy (gameObject);
        }
    }

    public void ShootEvent()
    {
        bulletScript.Fire();
    }
}
