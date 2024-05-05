using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float sens = 2;

    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sens;
        vertical = Input.GetAxis("Mouse Y") * sens;

        transform.Rotate(0, horizontal, vertical);
    }
}
