using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sun_AI : MonoBehaviour
{
    public GameObject sunflowerBullet;
    public Transform bulletSpawn;
    private GameObject newInstance;

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
        float instX = bulletSpawn.transform.position.x;
        float instY = bulletSpawn.transform.position.y;
        newInstance = Instantiate(sunflowerBullet, new Vector3(instX, instY, -1), Quaternion.identity);
    }
}
