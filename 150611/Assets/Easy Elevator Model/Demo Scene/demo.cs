using UnityEngine;
using System.Collections;

public class demo : MonoBehaviour {
	public	Transform	elevator;
	public	Transform	hallFrame;
	
	void Update () {
		if( Input.GetKeyDown( KeyCode.E ) ){
			elevator.animation.clip 	= elevator.animation.GetClip( "OpenDoors" );
			hallFrame.animation.clip 	= elevator.animation.GetClip( "OpenDoors" );
			elevator.animation.Play();
			hallFrame.animation.Play();
		}
		
		if( Input.GetKeyDown( KeyCode.R ) ){
			elevator.animation.clip 	= elevator.animation.GetClip( "CloseDoors" );
			hallFrame.animation.clip 	= elevator.animation.GetClip( "CloseDoors" );
			elevator.animation.Play();
			hallFrame.animation.Play();
		}
	}
}
