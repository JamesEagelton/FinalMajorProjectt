using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Lights1;
    public GameObject Lights2;
    public GameObject Lights3;
    public bool allLightsOn = false;
    
    
    
    void Start()
    {
      Lights1.SetActive(false);
      Lights2.SetActive(false);
      Lights3.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Invoke("Lights1On", 1f);
        Invoke("Lights2On", 3f);
        Invoke("Lights3On", 5f);
    }

    public void Lights1On() 
    { 
        Lights1.SetActive(true);
    
    }
    public void Lights2On()
    {
        Lights2.SetActive(true);

    }
    public void Lights3On()
    {
        Lights3.SetActive(true);
        allLightsOn = true;

    }

}
