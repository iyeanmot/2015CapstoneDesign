using UnityEngine;
using System.Collections;

public class indicator2 : MonoBehaviour {

    public bool isshow;
    //float alpha;
    //float OnTime;
    Vector3 scale;
    bool isbig;
	// Use this for initialization
	void Start () {
        isshow = true;
        //alpha = 0.0f;
       // OnTime = Time.time;
        //gameObject.transform.localPosition = transform.parent.position;
    }
	
	// Update is called once per frame
    void Update()
    {
        if (isshow)
        {
            if (gameObject.transform.localScale.x >= .5f)
            {
                isbig = false;           

            }
            else if (gameObject.transform.localScale.x <= .25f)
            {
                isbig = true;
            }
        }

        if(isbig)
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(.005f, .005f, .005f); 
        else
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(-.005f, -.005f, -.005f);
    }



}
