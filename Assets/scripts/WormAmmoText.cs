using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormAmmoText : MonoBehaviour
{

    public MGWFunctionality MGWfunctionality;
    public Text m_Text;
    string ammotext;
    
    void Start()
    {
        
    }

    
    void Update()
    {
         ammotext = MGWfunctionality.ammo.ToString();



          m_Text.text = ammotext;
    }
        
}
