using UnityEngine;
using System.Collections;

public class descen_pro : MonoBehaviour {
    public GameObject player_pro;
    public GameObject line;
    public bool check_player;
	// Use this for initialization
	void Start () {
	    player_pro = GameObject.Find("pro_player");
        check_player = false;
        line.SetActive(true);
        //gameObject.transform.localScale = new Vector3(.5f, .5f, .5f);
	}
	
	// Update is called once per frame
	void Update () {
	    if (check_player == true)
        {
            gameObject.transform.localScale =  new Vector3(1.5f,1.5f,2.5f);
            line.SetActive(false);
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel(5);
            }
        }
        else if (check_player == false)
        {
            line.SetActive(true);
            gameObject.transform.localScale = new Vector3(1, 1,2);
        }
	}
    void OnTriggerEnter(Collider col)
    {
        check_player = true;
        //Debug.Log("3");
    }
    void OnTriggerStay(Collider col)
    {
        check_player = true;
        //Debug.Log("2");
    }
    void OnTriggerExit(Collider col)
    {
        check_player = false;
       //Debug.Log("1");
    }
}
