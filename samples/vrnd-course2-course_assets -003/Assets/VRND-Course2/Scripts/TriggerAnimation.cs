using UnityEngine;
using System.Collections;

/// <summary>
/// TriggerAnimation is a script that activates a trigger parameter
/// that as the same name as the AnimationName variable
/// It requires a reference to the Animator and must be hooked up in the 
/// inspector. The class also deactiviates GoogleVR but keeps the 
/// event system enabled so that we can use the Trigger event from GVR
/// </summary>
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