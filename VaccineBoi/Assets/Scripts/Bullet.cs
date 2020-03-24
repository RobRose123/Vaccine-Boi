using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject hitEffect;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }
}
