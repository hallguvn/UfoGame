using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoMoveNormal_3 : MonoBehaviour
{
    public GameObject MoveParticle;
    public GameObject[] OutSideObjects;
    public GameObject StartPos;
    private int speed, flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
        GetComponent<UfoMoveNormal_2>().enabled = false;
        speed = 5;
        GetComponent<CapsuleCollider2D>().enabled = false;
        MoveParticle.SetActive(true);
        foreach (GameObject ob in OutSideObjects)
            ob.GetComponent<BackGroundMovement>().speed = ob.GetComponent<BackGroundMovement>().speed + 8;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, StartPos.GetComponent<Transform>().position, speed * Time.deltaTime);

        if (flag == 0)
        {
            StartCoroutine(EndThisMove());
            flag++;
        }
        
    }

    IEnumerator EndThisMove()
    {
        
        yield return new WaitForSeconds(8);
        GetComponent<UfoMoveNormal_2>().enabled = true;
        MoveParticle.SetActive(false);
        GetComponent<CapsuleCollider2D>().enabled = true;
        foreach (GameObject ob in OutSideObjects)
            ob.GetComponent<BackGroundMovement>().speed = ob.GetComponent<BackGroundMovement>().speed - 8;
        enabled = false;
    }
}
