using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject popUpContents = null; // Set in inspector.

    public void OpenPopUp()
    {
        popUpContents.SetActive(true);
    }

    public void ClosePopUp()
    {
        popUpContents.SetActive(false);
    }
}
