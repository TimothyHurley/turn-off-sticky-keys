using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Type : MonoBehaviour
{
    public bool isTyping = false;
    public TextMeshProUGUI wordOutput = null;
    public List<string> wordWhitelist = new List<string>();

    void Start()
    {
        SetWhitelist();
        ClearOutput();
    }

    void Update()
    {
        if (isTyping)
        {
            if (Input.anyKeyDown)
            {
                string keysDown = Input.inputString;

                if (keysDown.Length == 1)
                {
                    EnterInput(keysDown);
                }
            }

            if (Input.GetKeyDown("return"))
            {
                CheckOutput();
                ClearOutput();
            }
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
        wordOutput.text = "";
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
}
