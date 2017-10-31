using UnityEngine;
using System.Collections;

public class AgentSight : MonoBehaviour {

    public float viewAngle = 110f;
    public float viewDistance = 5;
    private GameObject player;
    public bool playerInsight = false;
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	
	void Update () {
    if(player != null)
       playerInsight =  checkAgentLocation();
    //Debug.Log(playerInsight);

	}
    
    bool checkAgentLocation()
    {
        if(Vector3.Distance(transform.position,player.transform.position) < viewDistance && Vector3.Angle((player.transform.position - transform.position),transform.forward) < viewAngle * 0.5f)
        {
            return true;
        }
        return false;
    }

}
