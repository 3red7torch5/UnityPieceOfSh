using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
	{
		other.gameObject.GetComponent<Coiner>().Reset();
	}
}
