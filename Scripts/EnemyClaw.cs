using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClaw : MonoBehaviour
{
    public int clawDamage = 100;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(clawDamage);
        }
        Debug.Log(hitInfo.name);        
    }
}
