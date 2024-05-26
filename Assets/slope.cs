using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slope : MonoBehaviour
{
    private float yOffset = 0.0f; // vertical offset of character origin from the ground
    private float raycastOffset = 0.5f; // height above character origin at which the raycast will fire downwards from
    private void LateUpdate()
    {
        if (Physics.Raycast(transform.position + (Vector3.up * raycastOffset), Vector3.down, out RaycastHit hit))
        {
            Vector3 position = transform.position;
            position.y = hit.point.y + yOffset;
            transform.position = position;
        }
    }

}
