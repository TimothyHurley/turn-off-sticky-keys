using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public bool isDoubleClicked = false;
    //public Button file = null;
    public GameObject[] files = null;
    public GameObject typeScript = null;
    //public GameObject popUp = null;
    public int timerInterval = 400;
    private Timer mouseClickTimer = new Timer();
    private Timer mouseDoubleClickTimer = new Timer();

    void Start()
    {
        //popUp.SetActive(false);

        mouseClickTimer.Interval = timerInterval;
        mouseClickTimer.Elapsed += SingleClick;

        mouseDoubleClickTimer.Interval = timerInterval;
        mouseDoubleClickTimer.Elapsed += DoubleClick;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (var file in files)
            {
                if (!file.GetComponent<File>().isButtonHeld)
                {
                    file.GetComponent<File>().HideHighlight();
                }
            }

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

                //popUp.SetActive(true);

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
