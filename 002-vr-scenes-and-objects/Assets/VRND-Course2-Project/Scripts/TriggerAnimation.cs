using UnityEngine;
using System.Collections;

public class TriggerAnimation : MonoBehaviour {
	[Tooltip("The name of the trigger parameter")]
	public string AnimationName; //name of the trigger parameter
	[Tooltip("The Animator Component we created")]
	public Animator stateMachine; //animator state machine

	void Update() {
		if (GvrViewer.Instance.Triggered)
			stateMachine.SetTrigger(AnimationName); //sets trigger
	}

}