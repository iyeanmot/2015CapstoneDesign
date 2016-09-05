using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class sm_sylen : MonoBehaviour {

	// Use this for initialization
    float OnTime;
    public Sprite On_image_1;
    public Sprite Off_image_1;
    public Sprite On_image_2;
    public Sprite Off_image_2;
	// Use this for initialization
	void Start () {
        OnTime = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - OnTime > 1)
        {
           
            //소화기 습득 시
            if (GameObject.Find("Player").GetComponent<sm_Item>().gethanki)
            {
                if (gameObject.GetComponentInChildren<Image>().sprite == On_image_2)
                    gameObject.GetComponentInChildren<Image>().sprite = Off_image_2;
                else
                    gameObject.GetComponentInChildren<Image>().sprite = On_image_2;
            }
            else
            {
                if (gameObject.GetComponentInChildren<Image>().sprite == On_image_1)
                    gameObject.GetComponentInChildren<Image>().sprite = Off_image_1;
                else
                    gameObject.GetComponentInChildren<Image>().sprite = On_image_1;
            }



            OnTime = Time.time;
        }


	}
}
