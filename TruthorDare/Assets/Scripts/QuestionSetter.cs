using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionSetter : MonoBehaviour
{
    public TMP_Text question;
    public void SetQuestion(string _question)
    {
        question.text = _question;
    }
}
