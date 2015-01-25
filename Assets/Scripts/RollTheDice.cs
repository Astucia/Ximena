using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RollTheDice : MonoBehaviour {

	private int selection;
	public string[] levelNames;
	public string[] decisions;
	public GameObject panel;
	public bool isFirst;

	// Use this for initialization
	void Start () {
		isFirst = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey && isFirst){
			isFirst = false;
			selection = Random.Range(0, 3);
			Debug.Log(selection);
			PlayerPrefs.SetString("Last Decision", decisions[selection]);
			panel.GetComponent<FadeOut>().initFade();
			StartCoroutine("changeScene");
		}
	}

	IEnumerator changeScene(){

		yield return new WaitForSeconds(2.0f);
		Application.LoadLevel(levelNames[selection]);
	}
}
