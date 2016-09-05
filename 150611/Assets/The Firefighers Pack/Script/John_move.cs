using UnityEngine;
using System.Collections;

public class John_move : MonoBehaviour {


    public int num;
    float old_time;
    // Use this for initialization
    void Start()
    {
        num = 0;
        old_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
		if (num == 0)
		{
			animation.CrossFade("Damage");
			if (Time.time - old_time > 3)
			{
				num = 1;
				old_time = Time.time;
			}
		}
		else if (num == 1)
		{
			animation.CrossFade("Idle");
			if (Time.time - old_time > 6)
			{
				num = 0;
				old_time = Time.time;
			}
		}
    }
}
