using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
	{
		other.gameObject.transform.GetComponent<Rigidbody>().velocity*=5;
	}
}
