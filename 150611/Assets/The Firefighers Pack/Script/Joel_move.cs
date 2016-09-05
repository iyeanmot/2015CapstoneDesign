using UnityEngine;
using System.Collections;

public class Joel_move : MonoBehaviour {


    public int num;
    float old_time;
    bool check;
    // Use this for initialization
    void Start()
    {
        num = 0;
        old_time = Time.time;
        check = false;
    }

    // Update is called once per frame
    void Update()
	{
		if (num == 0)
		{
			animation.CrossFade("Run");
			if (Time.time - old_time > 3)
			{
				num = 1;
				old_time = Time.time;
			}
		}
		else if (num == 1)
		{
			animation.CrossFade("Idle");
			if (Time.time - old_time > 8)
			{
				num = 0;
				old_time = Time.time;
			}
		}
    }
}
