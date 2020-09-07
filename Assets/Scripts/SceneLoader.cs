using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    private void Awake() {
        Instance = this;
    }

    public void LoadGameOverScene() {
        SceneManager.LoadScene(1);
    }

    public void LoadGameScene() {
        SceneManager.LoadScene(0);
    }
}
