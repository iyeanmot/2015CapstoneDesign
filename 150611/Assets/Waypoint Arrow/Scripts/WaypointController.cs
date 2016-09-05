using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class WaypointController : MonoBehaviour {

	//Transform used to reference the Waypoint Arrow
	[Tooltip("A reference to the Waypoint Arrow, used to manage the arrow.")]
	public Transform WaypointArrow;
	//Boolean used to automatically find the Waypont Arrow
	[Tooltip("Enable 'Auto Find Arrow' to automatically lookup the 'Waypoint Arrow' with GameObject.Find().")]
	public bool AutoFindArrow;
	//Transform used to identify the Waypoint Arrow's target
	public Transform CurrentWaypoint;
	//Int used to determine how many Waypoints should be used
	[Range(1,100)]public int TotalWaypoints;
	//Array of Transforms, the list in order of where the Waypoint Arrow will point to next
	public Transform[] Waypoints;

	GameObject newWaypoint;

	string newWaypointName;

	int nextWP;

	// Use this for initialization
	void Start () {
		//Check if Arrow should be automaticallsy found
		if(AutoFindArrow){
			//If true, the Waypoint Arrow is automatically found and a reference is established
			//WaypointArrow = GameObject.Find("/Player/Main Camera/Waypoint Arrow").transform;
			WaypointArrow.gameObject.SetActive(true);
		}
		nextWP = 0;
		CalculateWaypoints ();
		ChangeTarget ();
	}

	//Draws a Gizmo in the scene view window to show the Waypoints
	void OnDrawGizmosSelected() {
		for(var i = 0; i < TotalWaypoints; i++){
				Gizmos.DrawIcon(Waypoints[i].position, "Waypoint", true);
		}
	}

	void ChangeTarget(){
		float check = nextWP;
		if(check < TotalWaypoints){
			CurrentWaypoint = Waypoints[nextWP];
			nextWP += 1;
		}
		if (check == TotalWaypoints){
			Destroy(WaypointArrow.gameObject);
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		//Check if the script is being executed in the Unity Editor
		#if UNITY_EDITOR
			CalculateWaypoints ();
		#endif
		//Keep the Waypoint Arrow pointed at the Current Waypoint
		WaypointArrow.LookAt(CurrentWaypoint);
	}

	void CalculateWaypoints(){

		//Resize the Waypoints Array based on what the inspector value for Total Waypoints is set to.
		System.Array.Resize (ref Waypoints, TotalWaypoints);
		for(var i = 0; i < TotalWaypoints; i++){
			newWaypointName = "Waypoint " + (i + 1);
			if(Waypoints[i] == null){
				foreach (Transform child in transform){
					if(child.name == newWaypointName){
						Waypoints[i] = child;
					}
				}
				if(Waypoints[i] == null){
					newWaypoint = new GameObject(newWaypointName);
					newWaypoint.AddComponent<Waypoint>();
					newWaypoint.AddComponent<BoxCollider>();
					newWaypoint.collider.isTrigger = true;
					newWaypoint.transform.parent = gameObject.transform;
					Waypoints[i] = newWaypoint.transform;
					Debug.Log("Waypoint Controller created a new Waypoint: " + newWaypointName);
				}
			}
		}

	}

}