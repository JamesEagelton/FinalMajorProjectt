using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public turretLockOn turretLockOn;

    private void Start()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Worm")
        {
            Debug.Log("WORM HIT");
            turretLockOn.health = turretLockOn.health - 1;

        }



    }
}
