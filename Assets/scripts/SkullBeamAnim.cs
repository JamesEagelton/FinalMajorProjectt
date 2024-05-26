using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullBeamAnim : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    private void OnEnable()
    {
        animator.SetBool("Isenable", true);
        animator.SetBool("Isenable", false);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
