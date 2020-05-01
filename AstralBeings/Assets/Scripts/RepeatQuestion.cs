using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Debug.Log("clicked");
    }
}
