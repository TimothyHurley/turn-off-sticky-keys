using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class File : MonoBehaviour
{
    public bool isButtonHeld = false;
    public Image fileHighlight = null;
    public GameObject fileContents = null;
    public GameObject clickScript = null;

    void Start()
    {
        fileHighlight.enabled = false;
        fileContents.SetActive(false);
    }

    public void ShowHighlight()
    {
        if (fileHighlight.enabled && clickScript.GetComponent<Click>().isDoubleClicked)
        {
            HideHighlight();
            OpenFile();
        }

        else
        {
            foreach (var file in clickScript.GetComponent<Click>().files)
            {
                file.GetComponent<File>().HideHighlight();
            }

            fileHighlight.enabled = true;
        }
    }

    public void HideHighlight()
    {
        fileHighlight.enabled = false;
    }

    public void OpenFile()
    {
        fileContents.SetActive(true);
    }

    public void CloseFile()
    {
        fileContents.SetActive(false);
    }

    public void OnPointerDown()
    {
        isButtonHeld = true;
    }

    public void OnPointerUp()
    {
        isButtonHeld = false;
    }
}
