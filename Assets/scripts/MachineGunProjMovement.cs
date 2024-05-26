using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.XR;

public class MachineGunProjMovement : MonoBehaviour
{
    
    Rigidbody m_Rigidbody;
    public float m_Speed;
    MachineGunProjLookTowards MGPLT;
    public bool trackingBegun = false;
    public float m_speedStart;
    


    
    
    
    
    
    
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        MGPLT = GetComponent<MachineGunProjLookTowards>();
        m_speedStart = m_Speed;

    }

    // Update is called once per frame
    void Update()
    {

         m_Rigidbody.velocity = transform.forward * m_Speed;

        if (MGPLT.tracking == true && !trackingBegun) 
        {
            m_Speed = m_Speed - 0.5F;
            if (m_Speed == 0) 
            {
                trackingBegun = true;
               
            }
        }
        if (trackingBegun == true) 
        {
            Invoke("SpeedUp", 1);
        }        

       
        
        
        
    }

    public void SpeedUp() 
    {
        if (m_Speed < 25) 
        { 
        m_Speed = m_Speed + 1F;
        
        } 
    
    }
    
    
    

}
