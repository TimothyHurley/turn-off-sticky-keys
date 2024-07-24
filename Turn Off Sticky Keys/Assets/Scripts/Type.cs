using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Type : MonoBehaviour
{
    public TextMeshProUGUI wordOutput = null;
    public List<string> wordWhitelist = new List<string>();

    void Start()
    {
        SetWhitelist();
        ClearOutput();
    }

    void Update()
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
        }
    }

    private void SetWhitelist()
    {
        wordWhitelist.Add("Test");
        wordWhitelist.Add("24/07");
    }

    private void ClearOutput()
    {
        wordOutput.text = "";
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
                ClearOutput();
            }
        }
    }
}
