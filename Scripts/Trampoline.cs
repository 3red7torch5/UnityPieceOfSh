using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline: MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        other.gameObject.transform.GetComponent<Rigidbody>().velocity+=new Vector3(0,17,0);
    }
}
