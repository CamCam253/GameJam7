using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingButton : MonoBehaviour
{
    public float blinkSpeed = 1f; // Vilkku nopeus
    public Image buttonImage; //paitti siin ei oo mtn kuvaa nyt
    public bool isBlinking = true;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;

    void Start()
    {
        button1.onClick.AddListener(() => OnButtonClick(1));
        button2.onClick.AddListener(() => OnButtonClick(2));
        button3.onClick.AddListener(() => OnButtonClick(3));
        button4.onClick.AddListener(() => OnButtonClick(4));
        button5.onClick.AddListener(() => OnButtonClick(5));
        button6.onClick.AddListener(() => OnButtonClick(6));
        button7.onClick.AddListener(() => OnButtonClick(7));
        button8.onClick.AddListener(() => OnButtonClick(8));
        button9.onClick.AddListener(() => OnButtonClick(9));
    }


    // Update is called once per frame
    void Update()
    {
        float alpha = Mathf.Abs(Mathf.Sin(Time.time * blinkSpeed));
        Color newColor = buttonImage.color;
        newColor.a = alpha;
        buttonImage.color = newColor;
    }

    void OnButtonClick(int buttonNumber)
    {
        Debug.Log("Button " + buttonNumber + " clicked!"); // t‰s n‰kee mitÅEkaikkee tapahtuu
    }

    public void ToggleBlinking(bool state)
    {
        isBlinking = state;
    }
}
