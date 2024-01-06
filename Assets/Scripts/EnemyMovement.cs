using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent evilPerson;
    
    public float squareOfMovement = 20f;
    public float closeEnough = 2f; 
    
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;
    private float xPosition;
    private float yPosition;
    private float zPosition;

    void Start()
    {
        xMin = -squareOfMovement;
        xMax = squareOfMovement;
        zMin = -squareOfMovement;
        zMax = squareOfMovement;

        newLocation();

    }

    void Update()
    {
        if(Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) <= closeEnough)
        {
            newLocation();
            Debug.Log("yo 1");
        }
    }

    public void newLocation()
    {
        yPosition = transform.position.y;
        xPosition = Random.Range(xMin, xMax);
        zPosition = Random.Range(zMin, zMax);
        Debug.Log("yo");
        evilPerson.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }
}
