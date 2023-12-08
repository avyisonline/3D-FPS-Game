using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private EnemyMovement enemyMovement;
    private Transform player;
    public float attackRange = 10f;
    public Material defaultMaterial;
    public Material attackMaterial;
    private MeshRenderer rend;
    PlayerHealth health;

    private bool foundPlayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyMovement = GetComponent<EnemyMovement>();
        rend = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        health = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = attackMaterial;
            enemyMovement.evilPerson.SetDestination(player.position);
            foundPlayer = true;

        }else if (foundPlayer)
        {
            rend.sharedMaterial = defaultMaterial;
            enemyMovement.newLocation();
            foundPlayer = false;
        }
    }
}
