using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoHitEnamy : MonoBehaviour
{
    public GameObject gm;
    public GameObject ufo, DestroyUfoAnim, Endpanel;
    void Start()
    {
        ufo.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        gm = GameObject.Find("GameManager");
        ufo = GameObject.Find("Ufo");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ufo" && gameObject.tag == "enemy")
        {
            DestroyUfoAnim.SetActive(true);
            ufo.SetActive(false);
            StartCoroutine(EndGame());
        }
        else if (collision.gameObject.tag == "enemy")
        {
           
            StartCoroutine(EndGame());
        }

    }

    IEnumerator EndGame()
    {
        ufo.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        DestroyUfoAnim.SetActive(true);
        yield return new WaitForSeconds(2);
        Endpanel.SetActive(true);
        //ufo.SetActive(false);


    }
}
