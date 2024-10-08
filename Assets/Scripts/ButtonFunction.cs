using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;

public class ButtonFunction : MonoBehaviour
{

    public Button button;
    public List<Transform> lights;
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
        foreach (var light in lights)
        {
            Image on = light.GetChild(0).GetComponentInChildren<Image>(true);
            on.enabled = !on.enabled;
        }
    }
}
