using UnityEngine;
using System.Collections.Generic;

public class QuizInfo : MonoBehaviour
{
    private bool answer;
    private Dictionary<string, string> question = new Dictionary<string, string>();

    public void SetAnswer(bool answer)
    {
        this.answer = answer;
    }

    public bool GetAnswer() { return answer; }

    public void SetQuestion(string question, string answer)
    {
        if (!this.question.ContainsKey(question))
            this.question.Add(question, answer);
    }

    public Dictionary<string, string> GetQuestion()
    {
        return question;
    }
}