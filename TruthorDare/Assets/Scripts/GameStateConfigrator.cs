using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateConfigrator : MonoBehaviour
{
    public void SetGameState_MIX()
    {
        GameState.gameMode = GameState.GameMode.Mix;
    }
    public void SetGameState_FLIRT()
    {
        GameState.gameMode = GameState.GameMode.Flirt;
    }
    public void SetGameState_ADULT()
    {
        GameState.gameMode = GameState.GameMode.Adult;
    }
    public void SetGameState_Shame()
    {
        GameState.gameMode = GameState.GameMode.Shame;
    }

}
