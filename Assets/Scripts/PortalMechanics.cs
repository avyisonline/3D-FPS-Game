using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalMechanics : MonoBehaviour
{

    public CharacterController characterController;

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.CompareTag("Player")) // If you interact with something tagged with Portal
        {
            Debug.Log("Touchy Portal");
            SceneManager.LoadScene("YouWin"); // Sends you to the You Win screen :>
        }
    }
}
