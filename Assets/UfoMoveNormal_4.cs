using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoMoveNormal_4 : MonoBehaviour
{
    public int flag;
    public GameObject[] OutSideObjects;
    void Start()
    {
        flag = 0;
        GetComponent<UfoMoveNormal_2>().enabled = true;
        foreach (GameObject ob in OutSideObjects)
            ob.GetComponent<BackGroundMovement>().speed = ob.GetComponent<BackGroundMovement>().speed *2/10;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 0)
        {
            StartCoroutine(EndThisMove());
            flag++;
        }
            
    }

    IEnumerator EndThisMove()
    {

        yield return new WaitForSeconds(10);
        GetComponent<UfoMoveNormal_2>().enabled = true;
        foreach (GameObject ob in OutSideObjects)
            ob.GetComponent<BackGroundMovement>().speed = ob.GetComponent<BackGroundMovement>().speed *10 / 2;
        enabled = false;
    }
}
