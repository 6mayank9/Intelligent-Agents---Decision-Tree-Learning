using UnityEngine;
using TreeSharpPlus;
using System.Collections;

public class PlayerInvokeEvents : MonoBehaviour {

    public Behavior player;
    private Behavior agent;

    public Node Eat(Transform Food)
    {
        Debug.Log("Eating");
        return new Sequence(player.Node_GoTo(Food.position,1.0f), player.Node_Gesture("happy_hand_gesture"));
    }

    public Node Dig(Transform SoilObj)
    {
        Debug.Log("Digging");
        return new Sequence(player.Node_GoTo(SoilObj.position, 1.0f), player.Node_Gesture("happy_hand_gesture"));
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            
            if(hit.transform.parent != null && hit.transform.parent.gameObject.name == "Food Stand")
            {
                BehaviorEvent.Run(this.Eat(hit.transform.parent), player);
            }
            else if(hit.transform.gameObject.name == "Soil")
            {
                Debug.Log(player.Agent.AgentStatus);
                //if()
                BehaviorEvent.Run(this.Dig(hit.transform), player);
                
            }
        }
    }

}
