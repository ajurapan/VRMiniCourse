using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Require the component 
[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickUpParent : MonoBehaviour {


	//Create TrackedOject Variable:
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;

	void Awake () {
		//Assigned the variable
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}

	void FixedUpdate () {
		//A referece to the device:
		device = SteamVR_Controller.Input ((int)trackedObj.index);

		//Read the input from the devic, if there is an input, show debug log
		//GetTouch
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("GetTouch Trigger!!");
		}
		if (device.GetTouchDown (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("GetTouchDown Trigger!!");
		}
		if (device.GetTouchUp (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("GetTouchUp Trigger!!");
		}

		//GetPress
		if (device.GetPress (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("GetPress Trigger!!");
		}
		if (device.GetPressDown (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("GetPressDown Trigger!!");
		}
		if (device.GetPressUp (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("GetPressUp Trigger!!");
		}
			
	}

}
