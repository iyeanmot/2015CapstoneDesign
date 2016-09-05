using UnityEngine;
using System.Collections;

public class start_log : MonoBehaviour
{

    public int Level;
    void Start()
    {
        Level = 0;

        //Screen.SetResolution(1024, 768, true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {   

        if (GUI.Button(new Rect(Screen.width / 2 - 60 , Screen.height / 2 + 80, 200, 50), "학습하기"))
        {
            Application.LoadLevel(1);
        }
		if (GUI.Button(new Rect(Screen.width / 2 - 60 , Screen.height / 2 + 160, 200, 50), "게임방법"))
		{
			Application.LoadLevel(7);
		}
        if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 240, 200, 50), "종료하기"))
        {
            Application.Quit();
        }
    }

}
