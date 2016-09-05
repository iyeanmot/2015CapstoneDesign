using UnityEngine;
using System.Collections;

public class be_firebell : MonoBehaviour {

    public AudioClip Playbell;
    public GameObject click;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //void OnMouseDown()
    //{
    //    audio.PlayOneShot(Playbell);
    //    click.SetActive(false);
    //}
    void OnTriggerStay(Collider col)
    { 
        click.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
           
            audio.PlayOneShot(Playbell);
            col.GetComponent<de_Item>().firebell = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        click.SetActive(false);
    }
}
