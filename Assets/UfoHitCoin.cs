using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoHitCoin : MonoBehaviour
{
    public GameObject gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Hit: " + col.gameObject.name);
        if (col.gameObject.name == "Ufo" && gameObject.tag=="blue")
        {
            Destroy(gameObject);
            if (gm.GetComponent<ChangeMovement>().BlueCoinCount < 10)
                gm.GetComponent<ChangeMovement>().BlueCoinCount++;
        }
        else if (col.gameObject.name == "Ufo" && gameObject.tag == "purple")
        {
            Destroy(gameObject);
            if (gm.GetComponent<ChangeMovement>().PurpleCoinCount < 10)
                gm.GetComponent<ChangeMovement>().PurpleCoinCount++;
        }
        else if (col.gameObject.name == "Ufo" && gameObject.tag == "green")
        {
            Destroy(gameObject);
            if (gm.GetComponent<ChangeMovement>().GreenCoinCount<10)
                gm.GetComponent<ChangeMovement>().GreenCoinCount++;
        }
    }
}
