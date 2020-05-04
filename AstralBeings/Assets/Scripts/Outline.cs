using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline : MonoBehaviour
{
    private Material mat;
    public Camera myCam;
    private AudioSource audioS;
    
    void Start()
    {
        this.mat = GetComponent<Material>();
        gameObject.GetComponent<Renderer>().material.SetFloat("_OutlineEnabled", 0);
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
       GetMouseInfo();


    }

    void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material.SetFloat("_OutlineEnabled", 1);
        audioS.Play();
    }
   
    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.SetFloat("_OutlineEnabled", 0); 
		audioS.Stop(); 
    }
    void GetMouseInfo()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider.transform)//This detects the colliders transform if you just use hit.transform it gets the root parent at least thats what I found.
            {
                Debug.Log("Mouse is over " + name + ".");
                gameObject.GetComponent<Renderer>().material.SetFloat("_OutlineEnabled", 1);
            }
        }

    }
}
