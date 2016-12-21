using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

	public GameObject poof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

		Debug.Log ("click processed");

		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		Object.Instantiate(poof, transform.position, Quaternion.Euler(270,0,0));
		//Object.Instantiate(poof, transform.position, Quaternion.identity);
    }

}
