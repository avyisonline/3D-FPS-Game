using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public bool isDead;


    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            isDead=true;
        }
    }
}
