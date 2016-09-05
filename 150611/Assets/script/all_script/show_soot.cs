using UnityEngine;
using System.Collections;

public class show_soot : MonoBehaviour {


    Color originalColour;
    float newAlpha;
	// Use this for initialization
	void Start () {
        newAlpha = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (newAlpha < 1.1f)
        {
            newAlpha = Time.time * 0.005f *Time.deltaTime + newAlpha;
            //Debug.Log(newAlpha);
        }

        originalColour = renderer.material.color;
        renderer.material.color = new Color(originalColour.r, originalColour.g, originalColour.b, newAlpha);


    }
}
