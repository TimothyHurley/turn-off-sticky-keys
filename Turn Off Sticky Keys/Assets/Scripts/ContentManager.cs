using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentManager : MonoBehaviour
{
    public GameObject stickyKeysPopUp = null; // Set in inspector.
    public GameObject keyboardShortcutsPopUp = null; // Set in inspector.

    void Start()
    {
        stickyKeysPopUp.GetComponent<PopUp>().OpenPopUp();
    }
}
