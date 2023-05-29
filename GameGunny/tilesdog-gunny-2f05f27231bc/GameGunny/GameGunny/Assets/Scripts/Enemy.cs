using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject deathEffect;

	public float health = 4f;

	public static int EnemiesAlive = 0;

	public GameObject winGame;

	void Start ()
	{
		EnemiesAlive++;
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			Die();
		}
	}

	void Die ()
	{
		winGame.SetActive(true);
		Instantiate(deathEffect, transform.position, Quaternion.identity);

		EnemiesAlive--;
		Destroy(gameObject);
	}

}
