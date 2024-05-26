using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int Health;
    public bool death = false;

    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "bullet") 
        {
            Health = Health - 25;
        }
    }


    void Update()
    {
        if (Health <= 0)
        {
            dead();
        }
    
    }
    public void dead()
    {
        death = true;
        SceneManager.LoadScene(0);

    }
}
