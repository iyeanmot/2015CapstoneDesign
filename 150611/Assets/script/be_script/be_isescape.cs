using UnityEngine;
using System.Collections;

public class be_isescape : MonoBehaviour {

    public GameObject _Player;
    public GameObject _Eduboard;

	// Use this for initialization
	void Start () {
        //_Player = GameObject.Find("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        _Player.GetComponent<be_Item>().isEscape = true;
        _Eduboard.GetComponent<sm_eduboard>().Move_Camera(col.transform.position);
    
    }
}
