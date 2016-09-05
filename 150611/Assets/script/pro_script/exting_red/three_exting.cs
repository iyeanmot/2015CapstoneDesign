    using UnityEngine;
using System.Collections;

public class three_exting : MonoBehaviour {
    public GameObject Active;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("edu_camera").GetComponent<edu_board>().state > 4)
        {
            gameObject.SetActive(false);
            //Active.SetActive(true);
        }
	}
}
