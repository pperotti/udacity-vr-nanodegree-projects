using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;

	//Collects the status of the key
	public static bool isCollected = false;

	void Start() {
		isCollected = false;
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy

		Debug.Log ("OnKeyClicked " + isCollected);

		isCollected = true;

		Object.Instantiate(keyPoof, transform.position, Quaternion.Euler(270,0,0));

		//The door reacts to the update of the key status. The following line is no longer needed.
		//doorToOpen.Unlock ();

		Destroy (gameObject);
    }
}
