using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public KeyCode ShootKey;
	void Shoot()
	{
		GameObject projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		projectile.name = "projectile";
		projectile.transform.position = this.gameObject.transform.position + new Vector3(1,1,0);
		projectile.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
		projectile.GetComponent<Renderer>().material.color = Color.cyan;
		projectile.AddComponent<Rigidbody>();
		projectile.GetComponent<Rigidbody>().useGravity = false;
		projectile.GetComponent<Rigidbody>().velocity = this.gameObject.transform.TransformDirection(Vector3.forward) * 5;
	}
    void Update()
    {
		if (Input.GetKey(ShootKey))
		{
			Shoot();
		}
    }
}
