using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScreenshotGame : MonoBehaviour
{
    private int w, h;

    private void Awake()
    {
        w = Screen.width/3;
        h = w;
    }
    void Start()
    {
        print(w+"X"+h);
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Screenshot.TakeScreenshot_Static(500, 500); //To take a full screenshot use Screen.width, Screen.height
           Screenshot.TakeScreenshot_Static(w, h);
        }
    }


    public void ButtonScreenShot() {
       // Screenshot.TakeScreenshot_Static(500, 700);
        Screenshot.TakeScreenshot_Static(w, h);
    }
    private void hello() {
        
       // return 
    }
}
