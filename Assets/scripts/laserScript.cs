using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    public GameObject beam;
    
    
    public void BeamShoot() 
    {
        beam.SetActive(true);
    }

    public void BeamStop() 
    {
        beam.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BeamShoot();
        }
        if (Input.GetMouseButtonUp(0)) 
        { 
            BeamStop();
        }
    }
}
