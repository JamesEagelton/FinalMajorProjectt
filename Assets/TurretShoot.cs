using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame

    public GameObject eye;
    public GameObject bullet;
    bool canShoot = true;
    bool reload = false;
    GameObject currentBullet;
    public LightsOn LightsOn;
    AudioSource steam;


    private void OnEnable()
    {
        steam = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (canShoot && LightsOn.allLightsOn) 
        { 
            shoot();
            canShoot = false;
            reload = true;
        }
        if (reload) 
        {
            Invoke("Reload", 1f);
            reload = false;
        }
    }


    public void shoot() 
    {
       currentBullet = Instantiate(bullet, eye.transform.position, eye.transform.rotation);
        steam.Play();
       
       
    
    }

    public void Reload() 
    { 
        canShoot=true;
    }
}
