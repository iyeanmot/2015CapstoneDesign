using UnityEngine;
using System.Collections;

public class speech2 : MonoBehaviour {
    public GameObject white;
    public GameObject blue;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("exting").GetComponent<exting_pro>().check_player == false)
        {
            white.SetActive(true);
            white.transform.position = blue.transform.position;
            white.transform.rotation = blue.transform.rotation;
            blue.SetActive(false);
        }   
	}
}
