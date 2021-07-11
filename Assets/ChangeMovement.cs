using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMovement : MonoBehaviour
{
    public int BlueCoinCount, PurpleCoinCount, GreenCoinCount;
    public GameObject MainUfo;
    public GameObject BlueButton, PurpleButton, GreenButton;
    public GameObject BlueSlider, PurpleSlider, GreenSlider;
    void Start()
    {
        BlueCoinCount = 0;
        PurpleCoinCount = 0;
        GreenCoinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        BlueSlider.GetComponent<Slider>().value = BlueCoinCount;
        PurpleSlider.GetComponent<Slider>().value = PurpleCoinCount;
        GreenSlider.GetComponent<Slider>().value = GreenCoinCount;


      

        if (BlueCoinCount == 5)
        {
            BlueButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
            BlueButton.GetComponent<Button>().enabled = true;
        }

        else
        {
            BlueButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.45f);
            BlueButton.GetComponent<Button>().enabled = false;
        }
            

        if (PurpleCoinCount == 5)
        {
            PurpleButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
            PurpleButton.GetComponent<Button>().enabled = true;
        }

        else
        {
            PurpleButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.45f);
            PurpleButton.GetComponent<Button>().enabled = false;
        }
            

        if (GreenCoinCount == 5)
        {
            GreenButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
            GreenButton.GetComponent<Button>().enabled = true;
        }

        else
        {
            GreenButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.45f);
            GreenButton.GetComponent<Button>().enabled = false;
        }
            

    }

    public void ChangeToMove1() {
        MainUfo.GetComponent<UfoMoveNormal>().enabled = true;
        MainUfo.GetComponent<UfoMoveNormal_2>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_3>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_4>().enabled = false;
    }
    public void ChangeToMove2() {
        MainUfo.GetComponent<UfoMoveNormal_2>().enabled = true;
        MainUfo.GetComponent<UfoMoveNormal>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_3>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_4>().enabled = false;
    }
    public void ChangeToMove3() {
        MainUfo.GetComponent<UfoMoveNormal_3>().enabled = true;
        MainUfo.GetComponent<UfoMoveNormal>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_2>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_4>().enabled = false;
    }
    public void ChangeToMove4() {
        MainUfo.GetComponent<UfoMoveNormal_4>().enabled = true;
        MainUfo.GetComponent<UfoMoveNormal>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_2>().enabled = false;
        MainUfo.GetComponent<UfoMoveNormal_3>().enabled = false;
    }
}
