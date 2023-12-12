using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    void Start()
    {

    }

    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("DeathScreen");
        }
    }

    private void OnColliderStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            health -= 5;
        }

    }
}
