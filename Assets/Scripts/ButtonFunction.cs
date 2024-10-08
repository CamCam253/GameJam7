using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;

public class ButtonFunction : MonoBehaviour
{

    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Clicked()
    {
        UnityEngine.Debug.Log("Clicked");
    }
}
