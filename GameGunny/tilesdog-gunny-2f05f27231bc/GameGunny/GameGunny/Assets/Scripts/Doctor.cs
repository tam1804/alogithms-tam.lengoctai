using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MonoBehaviour
{
    public GameObject endGame;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        endGame.SetActive(true);
    }
}

