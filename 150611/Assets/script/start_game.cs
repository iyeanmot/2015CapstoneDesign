using UnityEngine;
using System.Collections;

public class start_game: MonoBehaviour
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
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		} 
	}
	void OnGUI()
	{           

		if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 240, 200, 50), "뒤로가기"))
		{
			Application.LoadLevel(0);
		}
	}
	
}
