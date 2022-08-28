using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public int playerHealth = 100;
    //public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        if(playerHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
