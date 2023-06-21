using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{



    public int health = 100;
    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Die();
    }

    void Die()
    {
        GameObject dieEffect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(dieEffect, 0.2f);
        Destroy(gameObject);
        GameControllerScript.instance.score += 1;
    }



}
