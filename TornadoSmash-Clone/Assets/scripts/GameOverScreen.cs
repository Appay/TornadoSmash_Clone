using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
   
   /* public void Setup()
    {
        gameObject.SetActive(true);
    }
   */
    public void returnMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

}
