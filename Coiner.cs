using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coiner : MonoBehaviour
{
	public int coins=0;
	public int health=20;
	public void AddCoin(int amount)
	{
		coins+=amount;
	}
	public void TakeDamage(int dmg)
	{
		health-=dmg;
		if (health<=0)
		{
			Reset();
		}
	}
	public void Reset()
	{
		coins=0;
		health=20;
		this.gameObject.transform.localPosition=GameObject.Find("SpawnPoint").transform.localPosition;
	}
}
