using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public AudioSource doorLocked;
	public AudioSource doorOpened;

	// Create a boolean value called "locked" that can be checked in Update() 
	bool isLocked = true;

	void Start() {
		doorLocked.enabled = false;
		doorOpened.enabled = false;
	}

    void Update() {
        // If the door is unlocked and it is not fully raised
        // Animate the door raising up
		if (Key.isCollected) {
			isLocked = false;
		}
    }

	public void DoorClicked() {
		if (isLocked) {
			//Play lock sound
			playLockSound();
		} else {
			Unlock ();
		}
	}
		

    public void Unlock()
    {
        // You'll need to set "locked" to true here
		Debug.Log("Unlock isLocked=" + isLocked);

		//PLay unlock sound
		animateDoor();
		playUnlockSound ();
    }

	private void animateDoor() {
		for (int i=1;i<21;i++) {
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x, 
				gameObject.transform.position.y + i, 
				gameObject.transform.position.z);
						
		}
	}

	private void playUnlockSound() {
		Debug.Log ("Unlock");
		doorLocked.enabled = true;
		doorLocked.Play ();
	}

	private void playLockSound() {
		Debug.Log ("Lock");
		//doorLocked.Play ();

		//AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		//audioSource.clip = Resources.Load("") as AudioClip;
		doorOpened.enabled = true;
		doorOpened.Play();
	}

}