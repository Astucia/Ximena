using UnityEngine;
using System.Collections;

public class PlayDiceAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey){
			animation.Play();
		}
	}
}
