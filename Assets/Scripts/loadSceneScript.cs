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
    // These are just all the different scenes the SceneManager can call to

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
        SceneManager.LoadScene("SecretLevel"); // (ooo secret)
    }

    public void loadDeath()
    {
        SceneManager.LoadScene("DeathScreen");
    }

    public void loadWin()
    {
        SceneManager.LoadScene("YouWin");
    }

    public void loadUltraDeath()
    {
        SceneManager.LoadScene("UltraCrash");
    }
}
