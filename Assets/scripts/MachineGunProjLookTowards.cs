using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunProjLookTowards : MonoBehaviour
{
    // Start is called before the first frame update

    public bool tracking = false;
    Transform nearestEnemy;
    public WormDestroy wormDestroy;
    public GameObject bloodEffect;
    public Transform bloodPoint;
    public Animator animator;






    private void OnTriggerEnter(Collider other)
    {

       
        if (other.tag == "Enemy") 
        {
            if (tracking == false) 
            { 
                nearestEnemy = other.transform;
                Debug.Log("Tracking");
                tracking = true;
            }
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tracking) 
        { 
            this.transform.LookAt(nearestEnemy);
            animator.SetBool("IsTracking", true);
        }

        if (wormDestroy.wormDeath) 
        {
            Instantiate(bloodEffect, bloodPoint.transform.position, bloodPoint.transform.rotation);
            Destroy(gameObject);
        }
    }
}
