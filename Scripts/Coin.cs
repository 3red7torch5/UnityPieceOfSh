using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	void Update()
	{
		this.gameObject.transform.Rotate(new Vector3(0,3,0));
	}
    void OnCollisionEnter(Collision other)
	{
		other.gameObject.GetComponent<Coiner>().AddCoin(1);
		Destroy(this.gameObject);
	}
}
