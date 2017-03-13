﻿using UnityEngine;
using System.Collections.Generic;

public class BulletHit : MonoBehaviour
{
    public float velocity=50.0f;
    public GameObject hit;
    public int maxHitPoints = 1;

    ParticleSystem bullet;
    Rigidbody rb;

    [HideInInspector]
    public GameObject target;

    void Awake()
    {
        bullet = GetComponent<ParticleSystem>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = velocity * transform.forward;
    }

    void OnParticleCollision(GameObject other)
    {
        if (other == target)
        {
            List<ParticleCollisionEvent> collisionEvents=new List<ParticleCollisionEvent>();
            bullet.GetCollisionEvents(other, collisionEvents);

            for (int i = 0; i < collisionEvents.Count && i < maxHitPoints; i++)
            {
                Instantiate(hit, collisionEvents[i].intersection, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
