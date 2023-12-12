using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthCounter;

    void Start()
    {
        healthCounter.text = health.ToString();
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
            healthCounter.text = health.ToString();
        }

    }
}
