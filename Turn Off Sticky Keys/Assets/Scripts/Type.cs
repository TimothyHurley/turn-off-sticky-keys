using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Type : MonoBehaviour
{
    public TextMeshProUGUI pinText = null; // Set in inspector;
    public TMP_InputField pinInputField = null; // Set in inspector.

    public bool isTyping = false; // Set in void Start().
    public string pin = "1984"; // Set in void Start().

    // LoadScene("name") set in void CheckOutput().

    void Start()
    {
        isTyping = false;
        pin = "1984";

        pinText.text = pin;
    }

    public void StartTyping()
    {
        isTyping = true;
    }

    public void StopTyping()
    {
        isTyping = false;
    }

    public void CheckOutput()
    {
        if (pinInputField.text == pin)
        {
            SceneManager.LoadScene("DesktopScene"); // Scene name.
        }

        else
        {
            // Add functionality here.
        }

        ClearOutput();
    }

    public void ClearOutput()
    {
        pinInputField.text = string.Empty;
    }
}
