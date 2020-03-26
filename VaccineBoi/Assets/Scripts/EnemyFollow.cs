﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    private List<Rigidbody2D> EnemyRBs;

    public float speed;

    private Transform playerPos;
    private Rigidbody2D rb;

    private float repelRange = 0.05f;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();

        if(EnemyRBs == null)
        {
            EnemyRBs = new List<Rigidbody2D>();
        }
    }

    private void OnDestroy()
    {
        EnemyRBs.Remove(rb);
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, playerPos.position) > 0.24f)
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        Vector2 repelForce = Vector2.zero;
        foreach(Rigidbody2D enemy in EnemyRBs)
        {
            if (enemy == rb)
                continue;

            if(Vector2.Distance(enemy.position, rb.position) <= repelRange)
            {
                Vector2 repelDir = (enemy.position - rb.position).normalized;
                repelForce += repelDir;
            }
        }
    }
}
