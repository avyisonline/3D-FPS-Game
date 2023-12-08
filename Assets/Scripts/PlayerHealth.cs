using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public bool isDead;

    private Transform NPC;

    public int normalDamage = 1;
    public int worseDamage = 2;

    public float damageRange = 3f;

    void Start()
    {
        NPC = GameObject.FindGameObjectWithTag("NPC").transform;
        isDead = false;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, NPC.position) <= damageRange)
        {
            health -= normalDamage;
        }

        if (health <= 0)
        {
            isDead=true;
        }
    }
}
