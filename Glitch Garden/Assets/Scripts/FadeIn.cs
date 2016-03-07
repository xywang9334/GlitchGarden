﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
	
	public float fadeTime;
	private Image fadePanel;
	private Color currentColor = Color.black;
	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeTime) {
			float deltaChange = Time.deltaTime / fadeTime;
			currentColor.a -= deltaChange;
			fadePanel.color = currentColor;
		} 
		else {
			gameObject.SetActive (false);
		}
	}
}
