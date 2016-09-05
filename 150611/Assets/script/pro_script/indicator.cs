using UnityEngine;
using System.Collections;

public class indicator : MonoBehaviour {

    public bool isshow;
    public float max_size;
    public float min_size;

    Vector3 scale;
    bool isbig;
    // Use this for initialization
    void Awake()
    {
    }
    void Start()
    {
        isshow = true;
        
    }
	
	// Update is called once per frame
    void Update()
    {
        if (isshow)
        {
            if (gameObject.transform.localScale.x >= max_size)
            {
                isbig = false;           

            }
            else if (gameObject.transform.localScale.x <= min_size)
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

