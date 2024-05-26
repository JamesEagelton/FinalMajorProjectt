using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwap : MonoBehaviour
{

    public GameObject currnetCrosshair;
    public GameObject[] Weapons;
    public Sprite[] crosshairs;
    public GameObject[] WeaponUi;
    public int currentWeapon;
    public bool firstLevel;
    public bool firstWeapon;
    public bool secondWeapon;
    
    
    
    
    void Start()
    {
        
        if(firstLevel == false) 
        {
            foreach (var weapon in Weapons)
            {
                weapon.SetActive(false);
            }
            foreach (var weapon in WeaponUi)
            {
                weapon.SetActive(false);
            }
            currnetCrosshair.SetActive(false);
        }
        
        if (firstLevel) 
        { 
            foreach(var weapon in Weapons) 
            { 
                weapon.SetActive(false); 
            }
            foreach(var weapon in WeaponUi) 
            { 
                weapon.SetActive(false);
            }
            Weapons[0].gameObject.SetActive(true);
            currentWeapon = 0;
            WeaponUi[0].SetActive(true);
            currnetCrosshair.GetComponent<Image>().sprite = crosshairs[0];
        }
    }



    public void FirstWeaponEquip() 
    {
        currnetCrosshair.SetActive(true);

        Weapons[currentWeapon].gameObject.SetActive(false);
        Weapons[0].gameObject.SetActive(true);
        WeaponUi[currentWeapon].SetActive(false);
        currentWeapon = 0;
        WeaponUi[0].SetActive(true);
        currnetCrosshair.GetComponent<Image>().sprite = crosshairs[0];

    }

    public void SecondWeaponEquip() 
    {

        Weapons[currentWeapon].gameObject.SetActive(false);
        Weapons[1].gameObject.SetActive(true);
        WeaponUi[currentWeapon].SetActive(false);
        currentWeapon = 1;
        WeaponUi[1].SetActive(true);
        currnetCrosshair.GetComponent<Image>().sprite = crosshairs[1];

    }
    
    
    void Update()
    {
        
        
        
        if (Input.GetKeyDown(KeyCode.Alpha1) && firstWeapon == true) 
        {
           FirstWeaponEquip();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && secondWeapon == true)
        {
            SecondWeaponEquip();
        }


    }
}
