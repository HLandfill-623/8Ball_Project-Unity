using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class magic8Ball : MonoBehaviour
{

    public TextMeshProUGUI answerText;
    

    void Start()
    {
    
    }

    private string[] answers = {"Yes", "No", "Without a doubt", "Reply hazy. Ask again",
            "Don't count on it", "Most likely", "Outlook not good", "Better not tell you now",
            "Error: Future not found.", "Why are you asking an 8ball?", "Totally!", "No way."};

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {


            int index = Random.Range(0, answers.Length);
            answerText.text = answers[index];

        }
    }
}
