using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class start_ca : MonoBehaviour {

    public AudioClip button_click;
   
	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(() => ButtonClick());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void ButtonClick()
    {
        Application.LoadLevel(2);
         audio.PlayOneShot(button_click);
    }
}
