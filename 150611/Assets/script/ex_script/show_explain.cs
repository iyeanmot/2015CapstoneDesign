using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class show_explain : MonoBehaviour {

    public Texture2D explain_1;
    public Texture2D explain_2;
    public Texture2D explain_3;
    public Texture2D explain_4;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if(GetComponentInParent<edu_board>().state ==1)
            gameObject.GetComponent<RawImage>().texture = explain_1;
        else if (GetComponentInParent<edu_board>().state ==2)
            gameObject.GetComponent<RawImage>().texture = explain_2;
        else if (GetComponentInParent<edu_board>().state == 3)
            gameObject.GetComponent<RawImage>().texture = explain_3;
        else if (GetComponentInParent<edu_board>().state == 4)
            gameObject.GetComponent<RawImage>().texture = explain_4;
        else if (GetComponentInParent<edu_board>().state > 4)
            gameObject.SetActive(false);
	
	}
}
