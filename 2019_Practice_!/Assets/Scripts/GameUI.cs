using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This should be a per player UI and score controller
//I would rename this script to TeamController, or maybe just move my code edits to a TeamController and attach that to a team prefab

public class GameUI : MonoBehaviour
{

    /*list of producers */
    [SerializeField] private Text Current_People;
    [SerializeField] private Text Current_Food;
    [SerializeField] private Text Current_Pollution;
    [SerializeField] private Text Current_Gold;
    [SerializeField] private Text Current_Metal;
    [SerializeField] private Text Current_Cotton;
    [SerializeField] private Text Current_Factory;
    [SerializeField] private Text Current_Farm;
    [SerializeField] private Text Current_Park;

    private Dictionary<string, int> teamResources;

    List<Producer> producersOwned;
    private int Gold_InitialScore = 10;
    private int Metal_InitialScore = 10;
    private int People_InitialScore = 3;
    private int Food_InitialScore = 3;
    private int Cotton_InitialScore = 5;
    private int Pollution_InitialScore = 1;
    private int Factory_InitialScore = 0;
    private int Farm_InitialScore = 0;
    private int Park_InitialScore = 0;
    //Make most references to the values of resources at the dictionary level rather than individual variables
    void Start()
    {
        People_DispScore(0);
        Food_DispScore(0);
        Pollution_DispScore(0);
        Gold_DispScore(0);
        Metal_DispScore(0);
        Cotton_DispScore(0);
        Factory_DispScore(0);
        Farm_DispScore(0);
        Park_DispScore(0);
        teamResources = new Dictionary<string, int>() {
            {"gold", 10},
            {"metal", 10},
            {"food", 5},
            {"cotton", 5}
        };
    }

    public void BuyProducer(Dictionary<string, int> prodCost) {
         foreach (string key in prodCost.Keys) {
             teamResources[key] = teamResources[key] - prodCost[key];
         }
    }

    public void EndRound() {
        foreach(Producer prod in producersOwned) {
            foreach (string key in prod.runCost.Keys) {
                teamResources[key] = teamResources[key] - prod.runCost[key];
            }
            foreach (string key in prod.runProduction.Keys) {
                teamResources[key] = teamResources[key] + prod.runProduction[key];
            }
        }
    }


    public void People_DispScore(int PeopleScore)
    {
        People_InitialScore += PeopleScore;
        Current_People.text = "<color=#ffffff>" + People_InitialScore.ToString() + "</color>";
    }

    public void Food_DispScore(int FoodScore)
    {
        Food_InitialScore += FoodScore;
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";
    }

    public void Pollution_DispScore(int PollutionScore)
    {
        Pollution_InitialScore += PollutionScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";
    }

    public void Gold_DispScore(int GoldScore)
    {
        Gold_InitialScore += GoldScore;
        Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";
    }

    public void Metal_DispScore(int MetalScore)
    {
        Metal_InitialScore += MetalScore;
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";
    }

    public void Cotton_DispScore(int CottonScore)
    {
        Cotton_InitialScore += CottonScore;
        Current_Cotton.text = "<color=#ffffff>" + Cotton_InitialScore.ToString() + "</color>";
    }

    public void Factory_DispScore(int FactoryScore)
    {
        Factory_InitialScore += FactoryScore;
        Current_Factory.text = "<color=#ffffff>" + Factory_InitialScore.ToString() + "</color>";
    }

    public void Farm_DispScore(int FarmScore)
    {
        Farm_InitialScore += FarmScore;
        Current_Farm.text = "<color=#ffffff>" + Farm_InitialScore.ToString() + "</color>";
    }

    public void Park_DispScore(int ParkScore)
    {
        Park_InitialScore += ParkScore;
        Current_Park.text = "<color=#ffffff>" + Park_InitialScore.ToString() + "</color>";
    }
       

    void Update()
    {
        
    }
}
