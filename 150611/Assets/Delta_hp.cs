using UnityEngine;
using System.Collections;

public class Delta_hp : MonoBehaviour {

	// Use this for initialization

    public float delta_hp;

	void Start () {
        delta_hp = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<fire_hp>().fire_check)     //불끄기 On
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (gameObject.GetComponent<fire_hp>().hp > 0)
                {
                    delta_hp += 10;
                }
            }
        }
	}
}
