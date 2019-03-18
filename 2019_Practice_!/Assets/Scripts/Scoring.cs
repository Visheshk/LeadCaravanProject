using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private GameUI GameUI;

    void Start()
    {
        GameUI = GameObject.Find("GameUI").GetComponent<GameUI>();
    }

    public void ParkScore()
    {     
        GameUI.Park_DispScore(1);
        GameUI.Gold_DispScore(-2);
        GameUI.Metal_DispScore(-3);
    }

    public void FactoryScore()
    {
        GameUI.Factory_DispScore(1);
        GameUI.Gold_DispScore(-2);
        GameUI.Metal_DispScore(-4);
    }

    public void FarmScore()
    {
        GameUI.Farm_DispScore(1);
        GameUI.Gold_DispScore(-4);
        GameUI.Metal_DispScore(-1);
    }

    void Update()
    {
        
    }
}
