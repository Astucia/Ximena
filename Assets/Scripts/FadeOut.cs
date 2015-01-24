using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOut : MonoBehaviour {

	public Image image;
	private Color color;
	public float speed;
	private float fadePercent;

	// Use this for initialization
	void Start () {
		color = image.color;
	}
	
	// Update is called once per frame
	void Update () {
		fadePercent += Time.deltaTime;
		color.a = Mathf.Lerp(0.0f, 1.0f, fadePercent * speed);
		image.color = color;
	}
}
