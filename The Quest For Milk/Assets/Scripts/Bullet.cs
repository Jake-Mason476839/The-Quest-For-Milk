using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        float xSpeed = -10.0f;
        transform.position += new Vector3(xSpeed * Time.deltaTime , 0, 0);
        Object.Destroy(gameObject, 2.0f);
    }
}
