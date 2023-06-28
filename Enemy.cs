using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed;
	public int damage = 1;
	public GameObject target;
    void Update()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position,target.transform.position,speed*Time.deltaTime);
		this.gameObject.transform.LookAt(target.transform.position);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name=="projectile")
		{
			GameObject.Destroy(this.gameObject);
		}
		if (other.gameObject.name=="Player")
		{
			other.gameObject.GetComponent<Coiner>().TakeDamage(damage);
		}
	}
}
