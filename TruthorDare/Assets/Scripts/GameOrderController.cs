using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOrderController : MonoBehaviour
{
    int gameTurnCount = 1;
    public string GetNextPlayerName()
    {
        if (gameTurnCount > GameInfo.players.Count)
        {
            gameTurnCount = 1;
            return GameInfo.players[gameTurnCount - 1];

        }
        else
        {
            gameTurnCount += 1;
            return GameInfo.players[gameTurnCount - 1];
        }
    }
    public string GetRandomPlayerName()
    {
        int value = Random.Range(0, GameInfo.players.Count);
        return GameInfo.players[value];
    }
}
