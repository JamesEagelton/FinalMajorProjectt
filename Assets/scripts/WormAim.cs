using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormAim : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform startBulletPosition;
    public float speed;
    public float rotationSpeed;
    public Camera maincamera;

    Vector3 startingDirection;

    void Start()
    {

        startingDirection = startBulletPosition.transform.forward;

    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            RaycastHit hit;
            Vector3 targetDirection;

            if (Physics.Raycast(Camera.main.transform.position, maincamera.transform.forward, out hit))
            {

                targetDirection = hit.transform.position - startBulletPosition.position;

            }
            else
            {

                targetDirection = startingDirection;
            }

            Vector3 newDirection = Vector3.RotateTowards(startBulletPosition.transform.forward, targetDirection, rotationSpeed * Time.deltaTime, 0.0f);
            startBulletPosition.transform.forward = newDirection;

            Rigidbody clone;
            clone = Instantiate(projectile, startBulletPosition.position, startBulletPosition.rotation) as Rigidbody;
            clone.velocity = targetDirection * speed;

        }

    }
}
