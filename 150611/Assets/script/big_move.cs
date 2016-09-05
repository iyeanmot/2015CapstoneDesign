using UnityEngine;
using System.Collections;

public class big_move : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
		animation.CrossFade("Idle");
	}
}
