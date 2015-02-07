using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	private OrbitCamera oc;
	// Use this for initialization
	void Start () {
		oc = GetComponent<OrbitCamera> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")){
			oc.enabled=!oc.enabled;
		}
		
	}
}
