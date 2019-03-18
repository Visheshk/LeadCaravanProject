using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//we need to add three buttons; "new factories" "trading section" "next round"
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        newRound();
        // startTradingSection();
    }

    void newRound() {
        generateProducers();
        // toggleTradingSection();
        // after some pause
        // toggleTradingSection();
        // togglefactoryBuyingSection();
        endRound();
    }

    //** FIRST TODO **//
    void generateProducers () {
        //this  code makes randomly generated factories/farms/parks (calling these producers for now) ready for purchase
        //and places the list at the top of the screen

        //do most of this code in the producer.cs
        
        //Factories have a bulding cost, which 
    }

    //** SECOND TODO **//
    void endRound () {
        //---for each team, consume running cost of producers from the team's resource pool
        //currently, just call each existing team's EndRound function. <- means that this should have a serializable list of teams in the game
    }


    // things beneath don't need to be coded
    void toggleTradingSection() {
        //only trades and internal operations should be available when trading section is toggled on in the round
        //does not need to be coded this round
    }

    //don't code now
    void togglefactoryBuyingSection () {

    }


    // Update is called once per frame
    void Update() {
        
    }
}
