using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunOff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sun;
    
    void Start()
    {
       sun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
