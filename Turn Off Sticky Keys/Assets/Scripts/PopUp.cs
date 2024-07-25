using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject popUpContents = null;

    void Start()
    {
        popUpContents = this.gameObject;

        popUpContents.SetActive(false);
    }

    public void OpenPopUp()
    {
        popUpContents.SetActive(true);
    }

    public void ClosePopUp()
    {
        popUpContents.SetActive(false);
    }
}
