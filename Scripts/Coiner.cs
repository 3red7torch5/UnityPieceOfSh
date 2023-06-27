using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coiner : MonoBehaviour
{
	public int coins=0;
	public void AddCoin(int amount)
	{
		coins+=amount;
	}
	public void Reset()
	{
		coins=0;
	}
}
