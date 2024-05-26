using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1Trigger : MonoBehaviour
{
    // Start is called before the first frame update

    public WeaponSwap weaponSwap;
    public GameObject WeaponGone;
    public GameObject door;
    public GameObject Smoke;
    public AudioSource explosion;
    
    private void OnTriggerEnter(Collider other)
    {
        weaponSwap.firstWeapon = true;
        weaponSwap.FirstWeaponEquip();
        Instantiate(Smoke, door.transform.position, door.transform.rotation);

        explosion.Play();
        
        Destroy(door);

        Destroy(WeaponGone);
    }


   
    
}
