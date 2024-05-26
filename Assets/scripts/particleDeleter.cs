using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDeleter : MonoBehaviour
{
    // Start is called before the first frame update

    public float waittime; 
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("PDelete", waittime);
    }


    public void PDelete() 
    { 
        Destroy(gameObject);
    
    }



}
