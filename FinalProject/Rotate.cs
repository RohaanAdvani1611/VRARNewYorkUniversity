using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 r;
    void Update()
    {
        transform.Rotate(r * Time.deltaTime);
    }
}
