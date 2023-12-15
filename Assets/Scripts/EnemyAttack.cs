using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class EnemyAttack : MonoBehaviour
{
    private EnemyMovement enemyMovement;
    private Transform player;
    public float attackRange;
    public Material defaultMaterial;
    public Material attackMaterial;
    private MeshRenderer rend;

    private bool foundPlayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Figure out where the Player  is
        enemyMovement = GetComponent<EnemyMovement>(); // Gets the movement
        rend = GetComponent<MeshRenderer>(); // Gets the mesh reindeer sorry renderererer
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange) // if the thing is close enough to the other thing
        {
            rend.sharedMaterial = attackMaterial; // it goes change colours
            enemyMovement.evilPerson.SetDestination(player.position); // it starts shmoving to the player
            foundPlayer = true; // and tells itself, good job bud you foundPlayer. good boy

        }
        else if (foundPlayer) // also now that you've found the player
        {
            rend.sharedMaterial = defaultMaterial; // go back to your normal color
            enemyMovement.newLocation(); // and go to somewhere else, shoo
            foundPlayer = false; // you haven't foundPlayer. bad
        }
    }
}
