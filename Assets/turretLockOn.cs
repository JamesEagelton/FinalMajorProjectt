using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretLockOn : MonoBehaviour
{
    // Start is called before the first frame update
    bool lockOn = false;
    public GameObject turret;
    public GameObject smokeeffect;
    Transform player;
    public int health = 10;
    public LightsOn LightsOn;
    public int turretDeathCount = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" ) 
        { 
            lockOn = true;
            player = other.transform;


        }
    }

    // Update is called once per frame

   

    public void Die() 
    {
        Destroy(turret);
        Instantiate(smokeeffect, turret.transform.position, Quaternion.identity);
    }


    void Update()
    {
        if (lockOn) 
        {
            turret.transform.LookAt(player);
        }
    
        if (health <= 0) 
        { 
            Die();
            turretDeathCount++;
            
        }
    
    
    }
}
