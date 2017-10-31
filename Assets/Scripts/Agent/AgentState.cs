using UnityEngine;
using System.Collections;
/**
   This class tracks the current state of the agent 
   and its surroundings.
*/
public class AgentState : MonoBehaviour
{

    public double energy { get; private set; }
    public double health { get; private set; }
    
    public bool foodNear { get; private set; }
    public bool enemyNear { get; private set; }
    public bool healthkitNear { get; private set; }
    public AgentState() {
        energy = 100;
        health = 100;
        
        foodNear = false;    
    }
    void updateState(bool _foodNear, bool _enemyNear, bool _healthkitNear){
        if(energy <= 99.99) energy += 0.01;
        if(health <= 99.99) health += 0.01;
        
        foodNear = _foodNear;
        enemyNear = _enemyNear;
        healthkitNear = _healthkitNear;
    }
    void updateEnergy(double energyChange){
        energy += energyChange;
    }
    void updateHealth(double healthChange){
        health += healthChange;
    }
    
}
