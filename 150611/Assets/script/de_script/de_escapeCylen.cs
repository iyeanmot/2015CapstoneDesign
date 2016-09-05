using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class de_escapeCylen : MonoBehaviour
{

    float OnTime;
    public Sprite On_image_1;
    public Sprite Off_image_1;

    // Use this for initialization
    void Start()
    {
        OnTime = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - OnTime > 1)
        {

            if (gameObject.GetComponent<Image>().sprite == On_image_1)
                gameObject.GetComponent<Image>().sprite = Off_image_1;
            else
                gameObject.GetComponent<Image>().sprite = On_image_1;
        }
         OnTime = Time.time;
    }


}


