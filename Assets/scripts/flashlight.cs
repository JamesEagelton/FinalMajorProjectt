using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject flashlightGO;
    public bool flashOn;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            flashOn = !flashOn;
        }

        if (flashOn)
        {
            flashlightGO.SetActive(true);
        }
        else 
        {
            flashlightGO.SetActive(false);
        }
    }
}
