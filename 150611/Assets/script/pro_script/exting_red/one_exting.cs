using UnityEngine;
using System.Collections;

public class one_exting : MonoBehaviour {
    public GameObject Active;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("edu_camera").GetComponent<edu_board>().state == 2)
        {
            gameObject.SetActive(false);
            Active.SetActive(true);
            Debug.Log("1");
        }
	}
}
