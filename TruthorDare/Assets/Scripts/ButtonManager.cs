using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure to include the TextMeshPro namespace

public class ButtonManager : MonoBehaviour
{
    // Reference to the TextMeshPro text component
    public TextMeshProUGUI textPanel;

    private string[] truth = new string[]
    {
        "What's the most embarrassing thing you've done while trying to impress someone?",
        "Have you ever had a crush on a friend's partner? What happened?",
        "What's the wildest place you've ever had a sexual encounter?",
        "Have you ever lied to get out of a bad date? What was the lie?",
        "What's a secret you've never told anyone?",
        "Have you ever cheated in a relationship? If so, why?",
        "What's your biggest turn-on and turn-off?",
        "What's the strangest dream you've ever had involving someone in this room?",
        "If you could hook up with anyone in this room, who would it be?",
        "What's the most scandalous photo you have on your phone?"
    };

    private string[] dare = new string[]
    {
        "Send a flirty text to the last person you texted.",
        "Do your best impression of someone in the room for 1 minute.",
        "Show the last five photos on your phone to everyone.",
        "Allow someone to give you a temporary tattoo using a pen.",
        "Let someone write a word on your body with a marker.",
        "Do a dance for one minute without music.",
        "Call a random contact and confess your love for them (even if it’s just for fun).",
        "Share a pick-up line you’ve used in the past.",
        "Wear socks on your hands for the next three rounds.",
        "Let someone else style your hair however they want."
    };

    public void TruthButton()
    {
        // Select a random truth question and display it
        int randomIndex = Random.Range(0, truth.Length);
        textPanel.text = truth[randomIndex];
    }

    public void DareButton()
    {
        // Select a random dare question and display it
        int randomIndex = Random.Range(0, dare.Length);
        textPanel.text = dare[randomIndex];
    }
}
