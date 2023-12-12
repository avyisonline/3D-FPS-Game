using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Literally the entire reason the Home menu, and Home buttons work.
/// It identifies the scenes and loads them. Pretty useful!
/// </summary>

public class loadScene : MonoBehaviour
{
    public void loadPlay()
    {
        SceneManager.LoadScene("theBigOne"); 
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
    public void loadSecret()
    {
        SceneManager.LoadScene("SecretLevel"); 
    }

    public void loadDeath()
    {
        SceneManager.LoadScene("DeathScreen");
    }
}
