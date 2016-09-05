using UnityEngine;
using System.Collections;

public class be_doorknob : MonoBehaviour {


    Color oldColor;
    float red;
    bool isred;
    public bool OpenDoor;

    public AudioClip Correct;
    public AudioClip InCorrect;

   // public GameObject _Player;

    // Use this for initialization
    void Start()
    {
        OpenDoor = false;
        oldColor = gameObject.renderer.material.color;
        red = gameObject.renderer.material.color.r;
    }
	
	// Update is called once per frame
	void Update () {


        if (gameObject.renderer.material.color.r >= 1)
        {
            isred = false;
        }
        else if (gameObject.renderer.material.color.r < oldColor.r)
        {
            isred = true;
        }


        if (isred)
            red = red + 0.005f;
        else
            red = red - 0.005f;

        gameObject.renderer.material.color = new Color(red, oldColor.g, oldColor.b, 1);

        //Debug.Log(red);
	}

    void OnMouseDown()
    {
        if (red < 0.5f)
        {
            Debug.Log("ddd");
            OpenDoor = true;
            audio.PlayOneShot(Correct);
        }
        else
            audio.PlayOneShot(InCorrect);
    }
}
