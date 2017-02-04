using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	//Sound to use 
	public AudioSource audioSource;

	//Next/Prev actions
	public GameObject nextStation;

	//Main Camera
	public GameObject player;

	public void loadStations() {
		print ("loadStation");
		SceneManager.LoadScene ("Stations");
	}

	public void roar(){
		print ("play");
		audioSource.Play();
	}

	public void clickAction() {
		print ("next");
		iTween.MoveTo(player, nextStation.transform.position, 0.5f);
	}

	public void quit() {
		print ("quit");
		SceneManager.LoadScene ("Instructions");
	}
}
