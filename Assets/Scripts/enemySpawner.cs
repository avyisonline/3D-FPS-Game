using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject OGEnemy;
    public GameObject OGWorseEnemy;

    public int enemyMax;
    public int worseEnemyMax;

    void Start()
    {
        for(int i = 0; i < enemyMax; i++)
        {
            GameObject enemy = Instantiate(OGEnemy);
        }

        for (int i = 0; i < worseEnemyMax; i++)
        {
            GameObject enemy = Instantiate(OGWorseEnemy);
        }
    }
}
