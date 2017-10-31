using UnityEngine;
using System.Collections;
using TreeSharpPlus;


public class PlayerBehavior : Behavior {
    public Transform player;
    public UnityEngine.UI.Slider energyBar;
    AgentState playerState;
    RaycastHit hit;
    Val<Vector3> position;
    void Start () {
        playerState = new AgentState();
        hit.point = player.position;
        position = Val.Value(() => hit.point);
        this.StartTree(new DecoratorLoop(Node_Gesture("idle_1")));
        
        energyBar.value = (float)playerState.health;    
    }
	
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
              
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            BehaviorEvent.Run(new Sequence(Node_GoTo(position)), this);
        }
        


    }
}
