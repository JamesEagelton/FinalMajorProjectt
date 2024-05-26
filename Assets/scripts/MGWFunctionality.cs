
using UnityEngine;

public class MGWFunctionality : MonoBehaviour
{
    public AudioSource shootSound;
    public AudioSource shootempty;
    public Transform FirePoint;
    public GameObject bullet;
    public int ammo = 100;
    public Camera fpsCam;
    public LayerMask hitable;
    public Transform camTrans;
    public float spread;
    public float shootForce;
    public float upwardsForce;

    public Transform startingTrans;

    public GameObject weapon;
    
    public Animator MGWShoot;
    public bool isFiring;
    private GameObject WormInstance;

    float shotCounter;
    public float rateOfFire = 0.05F;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        
        weapon.transform.rotation = startingTrans.rotation;
        MGWShoot.SetBool("IsEnable", true);

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButton(0))
        {
            
            MGWShoot.SetBool("IsEnable", false);
            MGWShoot.SetBool("Firing", true);
            isFiring= true;
        }
        else 
        {
            MGWShoot.SetBool("Firing", false);
            isFiring= false;
        }

        if (isFiring && ammo > 0)
        {
            shotCounter -= Time.deltaTime;

            if (shotCounter <= 0)
            {
                shotCounter = rateOfFire;
                Shoot();

            }


        }
        if (isFiring && ammo <= 0) 
        {
            shotCounter -= Time.deltaTime;

            if (shotCounter <= 0)
            {
                shotCounter = rateOfFire;
                shootempty.Play();

            }
        }


        else
        {
            shotCounter -= Time.deltaTime;

        }

        
    
    
    
    }

    private void Shoot() 
    {
        
        shootSound.Play();
        
        GameObject WormInstance = Instantiate (bullet, FirePoint.transform.position,FirePoint.rotation  );

        


        ammo = ammo - 1;

    }

    


    private void OnDisable()
    {
        isFiring = false;
    }

    
        
    
}

    



