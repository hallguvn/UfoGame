using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundGenerator : MonoBehaviour
{
    public GameObject DestroyPos, SpamPos;
    public GameObject[] Backgrounds;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Background: " + Backgrounds[0].transform.localPosition.x);
       // Debug.Log("SpamPos: " + DestroyPos.transform.localPosition.x);

        foreach(GameObject bg in Backgrounds)
        {
            //Debug.Log("Backgroundx " + bg.name + " " + Backgrounds[0].transform.localPosition.x);
            //Debug.Log("Destroyx " + DestroyPos.transform.localPosition.x);
            if(bg.transform.localPosition.x <= DestroyPos.transform.localPosition.x)
            {
                Debug.Log("spam ");
                bg.transform.localPosition = SpamPos.transform.localPosition;
            }
           
        }

    }
}
