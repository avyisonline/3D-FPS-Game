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
        healthCounter.text = health.ToString(); // Health, into a string. So it can go be Text
    }

    void Update()
    {
        if (health <= 0) // Is your health LESS THAN ZERO?! 
        {
            SceneManager.LoadScene("DeathScreen"); // ya dead
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NPC")) // If ya touch an NPC Thingy, it does thingy
        {
            health -= 5; // Damage being delt
            healthCounter.text = health.ToString(); // and then set it to a string so it can go be text
        }
    }
}
