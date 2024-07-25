using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using TMPro;

public class Type : MonoBehaviour
{
    public bool isTyping = false;
    public TextMeshProUGUI wordOutput = null;
    private string currentLetter = string.Empty;
    public List<string> wordWhitelist = new List<string>();
    public GameObject clickScript = null;
    public GameObject popUp = null;
    private Timer keyPressTimer = new Timer();

    void Start()
    {
        SetWhitelist();
        ClearOutput();

        keyPressTimer.Interval = clickScript.GetComponent<Click>().timerInterval;
        keyPressTimer.Elapsed += SinglePress;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.inputString != string.Empty)
            {
                string keysDown = Input.inputString;

                if (keysDown == currentLetter)
                {
                    popUp.SetActive(true);

                    ClearOutput();
                }

                else
                {
                    if (isTyping)
                    {
                        EnterInput(keysDown);
                    }

                    currentLetter = keysDown;

                    keyPressTimer.Start();
                }
            }
        }

        if (Input.GetKeyDown("return"))
        {
            CheckOutput();
            ClearOutput();
        }
    }

    public void StartTyping()
    {
        isTyping = true;
    }

    public void StopTyping()
    {
        ClearOutput();

        isTyping = false;
    }

    public void ClearOutput()
    {
        wordOutput.text = string.Empty;
    }

    private void SetWhitelist()
    {
        wordWhitelist.Add("Test");
        wordWhitelist.Add("24/07");
    }

    private void EnterInput(string typedLetter)
    {
        string typedLetters = wordOutput.text + typedLetter;

        wordOutput.text = typedLetters;
    }

    private void CheckOutput()
    {
        string output = wordOutput.text;
        
        foreach (string word in wordWhitelist)
        {
            if (output.Contains(word))
            {
                Debug.Log("successful search!"); // Add functionality here.
            }
        }
    }

    void SinglePress(object obj, System.EventArgs arg)
    {
        keyPressTimer.Stop();

        currentLetter = string.Empty;
    }
}
