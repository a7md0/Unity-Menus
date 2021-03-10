﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigate : MonoBehaviour {
    public void goToScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void exitGame() {
        Application.Quit();
    }
}
