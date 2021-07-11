using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveButtons : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject gm;
    // Start is called before the first frame update
    public void ActiveAllButtons()
    {
        gm.GetComponent<ChangeMovement>().BlueCoinCount = 5;
        gm.GetComponent<ChangeMovement>().PurpleCoinCount = 5;
        gm.GetComponent<ChangeMovement>().GreenCoinCount = 5;
        foreach (GameObject b in buttons)
            b.GetComponent<Button>().enabled = true;
    }
}
