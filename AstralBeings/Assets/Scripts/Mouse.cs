using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    
    private float distance = 10;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);   
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 pos = r.GetPoint(distance);
        transform.position = pos;
    }
}
