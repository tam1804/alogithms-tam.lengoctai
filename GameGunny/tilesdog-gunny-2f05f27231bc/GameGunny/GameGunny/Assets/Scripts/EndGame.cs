using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.GameCenter;

public class EndGame : MonoBehaviour
{
    public float delayLoadScene = 2f;
    public string nameScene = "GamePlay2";
    void Update()
    {
        
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextGame()
    {
        SceneManager.LoadScene(nameScene);
    }
}
