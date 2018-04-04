﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {
	/*
	public int buttonWidth;
	public int buttonHeight;
	private int origin_x;
	private int origin_y;

	// Use this for initialization
	void Start () {
		buttonWidth = 200;
		buttonHeight = 50;
		origin_x = Screen.width / 2 - buttonWidth / 2;
		origin_y = Screen.height / 2 - buttonHeight * 2;
	}

	void OnGUI() {
		if(GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Scene 1")) {
			Application.LoadLevel(1);
		}
		//if(GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 10, buttonWidth, buttonHeight), "Scene 2")) {
		//	Application.LoadLevel(2);
		//}
		if(GUI.Button(new Rect(origin_x, origin_y + buttonHeight * 2 + 20, buttonWidth, buttonHeight), "Exit")) {
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#else
			Application.Quit();
			#endif
		}
	}
	/*
	void OnGUI()
	{
		if(GUI.Button(new Rect(20,20,100,50), "Menu")) 
		{
			Application.LoadLevel(0);
		}
	}
	*/
	public void PlayGame ()
	{
		SceneManager.LoadScene(1);
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}
