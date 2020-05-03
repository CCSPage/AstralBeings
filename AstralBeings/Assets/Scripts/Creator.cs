using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    private AudioSource audioSource;
    public Transform[] Avatar;
    public Transform tt;
    public GameObject[] AvatarObj;
    public bool move = false;
    private int i;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        MouseDetect();
        if (move) {
            tt.position = Vector2.Lerp(tt.position, Avatar[i].position, Time.deltaTime*5f);
            tt.rotation = Quaternion.Lerp(tt.rotation, Avatar[i].rotation, Time.deltaTime*5f);
            float dist = Vector2.Distance(tt.position, Avatar[i].position);

            if (dist < 0.03) {
                
                tt.position = Avatar[i].position;
                tt.rotation = Avatar[i].rotation;
                move = false;
            }
            
        }
        //MouseSound();
       
    }
/*     void OnMouseDown()
    {
        if (gameObject.tag == "Face") {
            //audioSource.Play(0);
            Debug.Log("asd");
        }
    }*/
/*    void MouseSound() {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (hit.transform ) {
            audioSource.Play();
        }

    }*/

    void MouseDetect() {
       
        if (Input.GetMouseButton(0)&&!move) {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.transform != null||move)
            {
                                if (!this.audioSource.isPlaying)
                                {
                                    audioSource.Play(0);
                                }

                Debug.Log(hit.transform.gameObject.name);

                GameObject obj;
                obj = hit.transform.gameObject;
                tt = obj.transform;
                tt.position = obj.transform.position;
                
                if (hit.collider.gameObject.tag == "Arms")
                {
                    i = 0;
                    move = true;
                }
                if (hit.collider.gameObject.tag == "Torso")
                {
                    i = 1;
                    move = true;
                }
                if (hit.collider.gameObject.tag == "Eyes")
                {
                    i = 2;
                    move = true;
                }
                if (hit.collider.gameObject.tag == "Hair")
                {
                    i = 3;
                    move = true;
                }
                if (hit.collider.gameObject.tag == "Legs")
                {
                    i = 4;
                    move = true;
                }
                if (hit.collider.gameObject.tag == "Nose")
                {
                    i = 5;
                    move = true;
                }
                hit.collider.gameObject.transform.parent = Avatar[i].transform;
            }

        }
    }
}
