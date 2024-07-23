using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class DoubleClick : MonoBehaviour
{
    private Timer mouseClickTimer = new Timer();

    void Start()
    {
        mouseClickTimer.Interval = 400;
        mouseClickTimer.Elapsed += SingleClick;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
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
            }
        }
    }

    void SingleClick(object obj, System.EventArgs arg)
    {
        mouseClickTimer.Stop();

        Debug.Log("single click"); // Add functionality here.
    }
}
