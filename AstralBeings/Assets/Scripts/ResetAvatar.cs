using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAvatar : MonoBehaviour
{
    
    //string sceneName = currentScene.name;


    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene == SceneManager.GetSceneByName("Intro"))
        {
            if (transform.childCount > 0)
            {
                Destroy(transform.GetChild(0).gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (transform.childCount > 0)
            {
                Destroy(transform.GetChild(0).gameObject);
            }
        }
    }
}
