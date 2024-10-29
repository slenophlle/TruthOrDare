using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Question", menuName = "TurthOrDare/NewQuestion", order = 1)]
public class Question : ScriptableObject
{
    public enum QuestionType { Truth, Dear }
    public QuestionType questionType;
    public enum QuestionTopic { Normal, Flirt, Adult, Shame, ShotTime }
    public QuestionTopic questionTopic;

    public string question;
}
