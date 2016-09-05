using UnityEngine;
using System.Collections;

public class check_elevator : MonoBehaviour {


    public GameObject _EduCamera;
    public GameObject select_edu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider col)
    {
        if (col.name == "Player")
        {
            if (!select_edu.GetComponent<select_edu>().edu3_finished)
            {
                _EduCamera.SetActive(true);
                _EduCamera.GetComponent<sm_eduboard>().isON = true;
                _EduCamera.GetComponent<sm_eduboard>().Move_Camera(col.transform.position);
                select_edu.GetComponent<select_edu>().play_edu3();
            }
        }
        
    }

}
