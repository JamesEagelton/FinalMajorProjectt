using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    Rigidbody rb;
    
    public GameObject bullet;
    

   

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 1000);
        Invoke("destroyBullet", 3f);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            
            Destroy(bullet);
        }
       
    
    }

    private void destroyBullet() 
    { 
        Destroy(bullet);
    }  
}
