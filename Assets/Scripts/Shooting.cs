using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;
    public TMP_Text secretsFound;
    public int secretCounter;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.tag.Equals("Secret"))
                {
                    Destroy(hit.collider.gameObject);
                    secretCounter++;
                    secretsFound.text = secretCounter.ToString();
                }

            }
        }

        if (secretCounter >= 3)
        {
            SceneManager.LoadScene("SecretLevel");
        }
    }
}
