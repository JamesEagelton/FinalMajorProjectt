using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WormDestroy : MonoBehaviour
{

    public bool wormDeath = false;
    public float wormCountdown;
    public MachineGunProjLookTowards MGPLT;



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag != "Worm" && other.tag != "Player" )
        {
            wormDeath = true;

        }

    }

    public void Update()
    {
        Invoke("Countdown", wormCountdown);
    }

    public void Countdown() 
    {
        

        if (MGPLT.tracking == false) 
        { 
            wormDeath = true;
        
        }
    }
}
