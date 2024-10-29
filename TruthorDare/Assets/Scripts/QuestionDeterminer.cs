using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestionDeterminer : MonoBehaviour
{
    public List<Question> questions;
    // Mix, Flirt, Adult, ShotTime,Shame
    public void SetQuestionsAccordingTo_Mix()
    {
        GameInfo.gameQuestions.Clear();
        GameInfo.gameQuestions = questions;
    }
    public void SetQuestionsAccordingTo_Flirt()
    {
        GameInfo.gameQuestions.Clear();
        foreach (Question question in questions)
        {
            if (question.questionTopic == Question.QuestionTopic.Flirt)
            {
                GameInfo.gameQuestions.Add(question);
            }
        }
    }
    public void SetQuestionsAccordingTo_Adult()
    {
        GameInfo.gameQuestions.Clear();
        foreach (Question question in questions)
        {
            if (question.questionTopic == Question.QuestionTopic.Adult)
            {
                GameInfo.gameQuestions.Add(question);
            }
        }
    }
    public void SetQuestionsAccordingTo_ShotTime()
    {
        GameInfo.gameQuestions.Clear();
        foreach (Question question in questions)
        {
            if (question.questionTopic == Question.QuestionTopic.ShotTime)
            {
                GameInfo.gameQuestions.Add(question);
            }
        }
    }
    public void SetQuestionsAccordingTo_Shame()
    {
        GameInfo.gameQuestions.Clear();
        foreach (Question question in questions)
        {
            if (question.questionTopic == Question.QuestionTopic.Shame)
            {
                GameInfo.gameQuestions.Add(question);
            }
        }
    }

}
