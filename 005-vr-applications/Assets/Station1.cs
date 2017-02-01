using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Station1 : MonoBehaviour {

	public AudioSource audioSource;

	public void roar(){
		print ("play");
		audioSource.Play();
	}

	public void next() {
		print ("next");
	}

	public void prev() {
		print ("prev");
	}

	public void quit() {
		print ("quit");
	}
}
