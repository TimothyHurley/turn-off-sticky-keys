using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class File : MonoBehaviour
{
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
        if (clickScript.GetComponent<Click>().isDoubleClicked)
        {
            Debug.Log("FILE OPENS"); // Add functionality here.

            HideHighlight();
            OpenFile();
        }

        else
        {
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
}
