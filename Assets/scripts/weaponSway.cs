using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSway : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform startingTrans;
    public GameObject weapon;
    
    public float smooth;
    public float swayMultiplier;

    private void Start()
    {
       
    }

    private void OnEnable()
    {
        weapon.transform.rotation = startingTrans.rotation;   
    }


    void Update()
    {
        float mousex = Input.GetAxisRaw("Mouse X") * swayMultiplier;
        float mousey = Input.GetAxisRaw("Mouse Y") * swayMultiplier;
        float horizontalInput = Input.GetAxisRaw("Horizontal") * swayMultiplier;
        float verticalInput = Input.GetAxisRaw("Vertical") * swayMultiplier;

        

        Quaternion rotationX = Quaternion.AngleAxis(-mousey, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(mousex, Vector3.up);
        Quaternion MovementX = Quaternion.AngleAxis(-verticalInput, Vector3.right);
        Quaternion MovementY = Quaternion.AngleAxis(horizontalInput, Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;
        Quaternion targetRotationMovement = MovementX * MovementY;

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationMovement, smooth * Time.deltaTime);
    }
}
