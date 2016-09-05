using UnityEngine;
using System.Collections;

public class shack_camera : MonoBehaviour {

    public GameObject mCam;
    float count;
    float Ontime;
	// Use this for initialization
	void Start () {
        count = (int)Random.Range(1, 51);
        Ontime = Time.time;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Time.time - Ontime > 10)
        {
            Vector3 position = mCam.transform.position;
            Shake_Cam();
            Ontime = Time.time;
            mCam.transform.position = position;
        }

    }
    void Shake_Cam()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 pos = mCam.transform.position;
            if (count % 10 < 5)
                pos.x -= 0.1f;
            else
                pos.x += 0.1f;
            mCam.transform.position = pos;

            count = (int)Random.Range(1, 51);
        }
    }
}
