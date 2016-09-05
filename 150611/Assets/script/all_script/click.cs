using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class click : MonoBehaviour {

    float OnTime;
    public Sprite On_image;
    public Sprite Off_image;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Time.time - OnTime > 0.5)
        {

            if (gameObject.GetComponentInChildren<Image>().sprite == On_image)
                gameObject.GetComponentInChildren<Image>().sprite = Off_image;
            else
                gameObject.GetComponentInChildren<Image>().sprite = On_image;


            OnTime = Time.time;
        }
    }
}
