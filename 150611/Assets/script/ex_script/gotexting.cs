using UnityEngine;
using System.Collections;

public class gotexting : MonoBehaviour {


    public GameObject spread;
    public void spreadExting()
    {
        Instantiate(spread, gameObject.transform.position, Quaternion.identity);

    }
	// Use this for initialization
    void Awake()
    {
        
    }
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
