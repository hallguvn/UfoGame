using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UfoMoveNormal_2 : MonoBehaviour
{
  
    public float speed = 1.5f;
    private Vector3 target;

    private void Start()
    {
        GetComponent<CapsuleCollider2D>().enabled = true;
        target = transform.position;
    }
    void Update()
    {
        
       

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        
        if (target.x < transform.position.x)
        {
            GetComponent<Animator>().enabled = false;
            transform.eulerAngles = Vector3.back * -15;  
        }
            
        else if (target.x > transform.position.x)
        {
            GetComponent<Animator>().enabled = false;
            transform.eulerAngles = Vector3.forward * -5;

        }
        else
            GetComponent<Animator>().enabled = true;


    }

   

}
