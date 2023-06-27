using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointCreator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		GameObject spawn = new GameObject("SpawnPoint");
		spawn.transform.localPosition=this.gameObject.transform.localPosition;
	}
}