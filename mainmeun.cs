﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmeun : MonoBehaviour {

	// Use this for initialization
	public void Playgame () {
        SceneManager.LoadScene(1);
	}

 /*   public void Quitgame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }*/
}
  