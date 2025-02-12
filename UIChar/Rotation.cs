using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 0.7f, 0);
    }
}
