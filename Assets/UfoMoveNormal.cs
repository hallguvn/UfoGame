using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoMoveNormal : MonoBehaviour
{
     private Vector3 FirstPoint, SecondPoint;
     private int flag, flagPioneer;
    // private bool PioneerOnEndPoint, UfoOnEndPoint, PioneerEndPointChanged, UfoEndPointChanged;
    public float speed = 1.5f, speedPioneer = 1.5f;
    public GameObject pioneer, TempUfo;
    private Vector3 target, Pioneertarget;
    private bool SecondClick, PioneerOnEndPoint;
    public GameObject VectorParticleF, VectorParticleS;
    void Start()
    {
        GetComponent<UfoMoveNormal_2>().enabled = false;
        GetComponent<CapsuleCollider2D>().enabled = true;
        FirstPoint = transform.position;
        flag = 0;
        SecondClick = false;
        PioneerOnEndPoint = false;
         target = transform.position;
        Pioneertarget = transform.position;
        
    }

    void Update()
    {
        
        VectorParticleS.transform.position = target;

        Debug.Log(SecondClick);
        if (pioneer.transform.position != transform.position)
        {
            SecondClick = true;
        }
        else
        {
            SecondClick = false;
        }


        if (SecondClick == true)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            pioneer.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
 
        }






        if (Input.GetMouseButtonDown(0) && SecondClick == false)
        {
            pioneer.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            Pioneertarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Pioneertarget.z = transform.position.z;
            
        }
       
        pioneer.transform.position = Vector3.MoveTowards(pioneer.transform.position, Pioneertarget, speedPioneer * Time.deltaTime);
        if (pioneer.transform.position == Pioneertarget)
        {
           PioneerOnEndPoint = true;
        }
        else
            PioneerOnEndPoint = false;

        if (Input.GetMouseButtonDown(0) && SecondClick == true)
        {
            VectorParticleF.transform.position = transform.position;
            StartCoroutine(VectorAnim());
            FirstPoint = transform.position;
            Pioneertarget = pioneer.transform.position;
             target = pioneer.transform.position;
            target.z = transform.position.z;  
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);


        if (transform.position == target)
        {
           TempUfo.transform.position = target;
        }
        if (flag == 0)
        {
            StartCoroutine(EndThisMove());
            flag++;
        }
    }

    IEnumerator VectorAnim()
    {
        VectorParticleS.SetActive(true);
        VectorParticleF.SetActive(true);
        yield return new WaitForSeconds(3f);
        VectorParticleF.SetActive(false);
        VectorParticleS.SetActive(false);
    }

    IEnumerator EndThisMove()
    {

        yield return new WaitForSeconds(25);
        GetComponent<UfoMoveNormal_2>().enabled = true;
        enabled = false;
    }

}
