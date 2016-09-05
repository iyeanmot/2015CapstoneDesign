using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class start_ca2 : MonoBehaviour {

     public AudioClip button_click;
    

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => ButtonClick());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ButtonClick()
    {
        Application.LoadLevel(3);audio.PlayOneShot(button_click);
    }
}
