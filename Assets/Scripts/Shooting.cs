using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Shooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;
    public TMP_Text secretsFound;
    public int secretCounter;
    public TMP_Text enemyKilled;
    public int enemyKilledCounter;
    public AudioSource[] soundFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            soundFX[0].Play();
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {
                    Destroy(hit.collider.gameObject);
                    soundFX[1].Play();
                    enemyKilledCounter++;
                    enemyKilled.text = enemyKilledCounter.ToString();
                }

                if (hit.collider.tag.Equals("Secret"))
                {
                    Destroy(hit.collider.gameObject);
                    secretCounter++;
                    secretsFound.text = secretCounter.ToString();
                }
                else
                {
                    return;
                }
            }
        }

        if (enemyKilledCounter >= 25 && secretCounter >= 3)
        {
            SceneManager.LoadScene("SecretLevel");
        }
    }
}
