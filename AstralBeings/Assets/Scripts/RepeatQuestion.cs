using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RepeatQuestion : MonoBehaviour
{
    AudioSource Question;
    // Start is called before the first frame update
    void Start()
    {
        Question = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   public void QuestionPlay()
    {
        Question.Play();
        
    }
    public void NextScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(1);
    }
}
