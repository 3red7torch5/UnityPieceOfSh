using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public GameObject me;
	public GameObject target;
    void OnCollisionEnter(Collision other)
	{
		other.gameObject.transform.position=target.transform.position;
	}
}
