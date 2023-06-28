using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 targetPos;
    private Vector3 movefactor;
    private Vector3 pos;
	public int accuracy=10;
	private Vector3 changer;
    void Move()
    {
        this.gameObject.transform.position += movefactor + 0.025f * (targetPos - pos);
    }
	void Swap()
	{
		changer=startPos;
		startPos=targetPos;
		targetPos=changer;
	}
    void Start(){}
    void Update()
    {
	pos=this.gameObject.transform.position;
	movefactor=(targetPos - pos)/accuracy;
        if (movefactor==Vector3.zero)
        {
			Swap();
            Move();
        }
        else
        {
            Move();
        }
    }
}
