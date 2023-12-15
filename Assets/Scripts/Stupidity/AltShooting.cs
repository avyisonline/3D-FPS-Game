using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class AltShooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;

    private int secretsFound = 0;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.tag.Equals("Secret"))
                {
                    Destroy(hit.collider.gameObject);
                    secretsFound++;
                }
                else
                {
                    return;
                }
            }
        }

        if (secretsFound >= 1)
        {
            SceneManager.LoadScene("UltraCrash");
        }

    }
}
