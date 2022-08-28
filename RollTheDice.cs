using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollTheDice : MonoBehaviour
{
    public PlayerHealth scriptHealth;
    public BulletScript scriptBullet;
    public PlayerMover scriptMover;

    public GameObject bulletForDamage;

    public float RadNum = 0f;

    public void Start()
    {
        scriptBullet = bulletForDamage.GetComponent<BulletScript>();
        PlayerHealth playerHealth = this.GetComponent<PlayerHealth>();
    }

    public void Update()
    {
        RadNum = Random.Range(1, 7);        
        if (Input.GetKeyDown("r"))
        {
            if(RadNum == 6)
            {
                scriptHealth.playerHealth *= 10;
            }
            else if (RadNum == 5)
            {
                scriptBullet.damage *= 10;
            }
            else if (RadNum == 4)
            {
                scriptBullet.damage *= 2;
            }
            else if (RadNum == 3)
            {
                scriptBullet.damage = 25;
            }
            else if (RadNum == 2)
            {
                scriptMover.runSpeed = 2;
            }
            else if (RadNum == 1)
            {
                scriptHealth.Die();
            }

        }
        
        
    }
   
}
