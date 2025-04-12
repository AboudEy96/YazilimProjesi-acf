using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ImagesList : MonoBehaviour
{

    public List<string> texts = new List<string>();
    public GameObject buttonQuit;
    public GameObject buttonNext;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI lvl;

    public Image img;
    private int bilgiLeveli = 1;
    private QuizInfo quizInfo;
    public void ButtonNextClick()
    {
        if (texts.Count == 0)
        {
            txt.SetText("Game Over ^_^");
            buttonNext.SetActive(false);
            buttonQuit.SetActive(true);
        }
        else
        {
   
            string randomText = texts[Random.Range(0, texts.Count)];
            bilgiLeveli++;
            lvl.text = $"Bilgi Leveli: {bilgiLeveli} / {texts.Count}";
            texts.Remove(randomText);
            txt.text = randomText;
            //quizInfo.SetQuestion(randomText);
        }

    }

 
}