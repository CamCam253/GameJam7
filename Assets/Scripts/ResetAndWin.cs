using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ResetAndWin : MonoBehaviour
{
    public int lightsOn;
    public int lightsOff;
    public List<Transform> lights;
    public Button reset;
    public int sceneNum;
    public Text successMessage;

    // Start is called before the first frame update
    void Start()
    {
        lightsOn = 0;
        lightsOff = lights.Count;
        reset.onClick.AddListener(Reset);

        successMessage.gameObject.SetActive(false);
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
            //Vaihtää skenee jos kaikki valot ovat päällä
            SceneManager.LoadScene(sceneNum);
            successMessage.text = "You win!";
            successMessage.gameObject.SetActive(true);

            // Pieni odotus hetki
            Invoke("LoadNextScene", 2.0f);
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
        successMessage.gameObject.SetActive(false);
   }
    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
