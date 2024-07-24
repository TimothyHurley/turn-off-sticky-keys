using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public bool isDoubleClicked = false;
    public Button file = null;
    public GameObject typeScript = null;
    private Timer mouseClickTimer = new Timer();
    private Timer mouseDoubleClickTimer = new Timer();

    void Start()
    {
        mouseClickTimer.Interval = 400;
        mouseClickTimer.Elapsed += SingleClick;

        mouseDoubleClickTimer.Interval = 400;
        mouseDoubleClickTimer.Elapsed += DoubleClick;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            file.GetComponent<File>().HideHighlight();

            if (typeScript.GetComponent<Type>().isTyping)
            {
                typeScript.GetComponent<Type>().isTyping = false;
            }

            if (mouseClickTimer.Enabled == false)
            {
                mouseClickTimer.Start();

                // Wait for double click.

                return;
            }

            else
            {
                // Double click has been performed.

                mouseClickTimer.Stop();

                Debug.Log("double click"); // Add functionality here.

                isDoubleClicked = true;

                mouseDoubleClickTimer.Start();
            }
        }
    }

    void SingleClick(object obj, System.EventArgs arg)
    {
        mouseClickTimer.Stop();

        Debug.Log("single click"); // Add functionality here.
    }

    void DoubleClick(object obj, System.EventArgs arg)
    {
        mouseDoubleClickTimer.Stop();

        isDoubleClicked = false;
    }
}
