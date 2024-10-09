using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ResetAndWin : MonoBehaviour
{
    public int lightsOn;
    public int lightsOff;
    public List<Transform> lights;
    public Button reset;

    // Start is called before the first frame update
    void Start()
    {
        lightsOn = 0;
        lightsOff = lights.Count;
        reset.onClick.AddListener(Reset);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var light in lights)
        {
            Image on = light.GetChild(0).GetComponentInChildren<Image>(true);


            if (on.enabled == true && lightsOn < lights.Count)
            {
                lightsOn++;
                lightsOff--;
            }
            else if (on.enabled == false && lightsOn > 0)
            {
                lightsOn--;
                lightsOff++;
            }
        }

        if (lightsOn == lights.Count && lightsOff == 0)
        {
            UnityEngine.Debug.Log("You Win!");
        }
        else
        {
            lightsOn = 0;
            lightsOff = lights.Count;
        }
    }

    void Reset()
    {
        foreach (var light in lights)
        {
            Image on = light.GetChild(0).GetComponentInChildren<Image>(true);
            on.enabled = false;
        }
    }
}
