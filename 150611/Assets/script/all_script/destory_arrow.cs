using UnityEngine;
using System.Collections;

public class destory_arrow : MonoBehaviour {
    public GameObject player;
    public GameObject Controller;
   //new Vector3 R;
   //public bool isshow;

   //float before;
   //float after;
   //float abs;

   //bool goleft;
	// Use this for initialization
	void Start () {
        //R = new Vector3(0, 0, 270);
        //isshow = true;
        //before = gameObject.transform.position.x;

        //goleft = true;
	}
	
	// Update is called once per frame


    void Update()
    {
        if (player.GetComponent<getItem>().getexing)
        {
            Destroy(gameObject);
            Destroy(Controller);
        }
        //abs = Mathf.Abs(before - gameObject.transform.position.x);

        //if (isshow)
        //{
        //    if (abs < .5)
        //    {
        //        goleft = true;
        //    }
        //    else if (abs == 0)
        //    {
        //        goleft = false;
        //    }
        //}

        //if (goleft)
        //    gameObject.transform.localPosition = gameObject.transform.localPosition + new Vector3(.005f, 0, 0);
        //else
        //    gameObject.transform.localPosition = gameObject.transform.localPosition + new Vector3(-.005f, 0, 0);

    }
}
