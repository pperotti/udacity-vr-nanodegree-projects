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
    public string AnimationName; //name of the trigger parameter
    public Animator stateMachine; //animator state machine

    private bool created = false; //variable to maintain state of whether GVR was instantiated or already existed

    void Awake() {
        if (GvrViewer.Instance == null) {
            GvrViewer.Create();
            created = true;
        }
    }

    void Start() {
        if (created) {
            foreach (Camera c in GvrViewer.Instance.GetComponentsInChildren<Camera>()) {
                c.enabled = false; // to use the Gvr SDK without adding cameras we have to disable them
            }
        }

    }

    void Update() {
        GvrViewer.Instance.UpdateState(); //need to update the data here otherwise we dont get mouse clicks; this is because we are automatically creating the GVRSDK (seems like a bug)
        if (GvrViewer.Instance.Triggered)
            stateMachine.SetTrigger(AnimationName); //sets trigger
    }

}