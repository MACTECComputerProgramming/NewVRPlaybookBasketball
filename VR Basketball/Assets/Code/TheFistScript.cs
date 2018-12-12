using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TheFistScript : MonoBehaviour {


	public GameObject[] players;
    
	public GameObject playerView;
    public GameObject capsule;

    public Transform[] playerWaypoints;

    public int playerID;
	public int actionValue;
    public int playNum;

	// Use this for initialization
	void Start () {		
		if(true /*PlayerNumber == 1*/){
            playerView.transform.position = new Vector3(players[0].transform.position.x, players[0].transform.position.y + 1, players[0].transform.position.z);
			playerView.transform.parent = players[0].transform;
            capsule.transform.position = playerWaypoints[0].transform.position;
		}

	}
	
	// Update is called once per frame
	void Update () {
        


	}





	public void NextAction()
	{
		actionValue ++;
        if (actionValue == 1)
        {
            StartCoroutine(NextMovement(actionValue, playerWaypoints[0], players[0]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[1], players[1]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[2], players[2]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[3], players[3]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[4], players[4]));


        }



		if(actionValue == 2)
		{
			Shoot (1);
		}
		if(true)
		{
			
		}




	}


	public IEnumerator NextMovement(int stepNumber, Transform playerWaypoint, GameObject player)
	{
        Debug.Log("start movement");
        while (player.transform.position != playerWaypoint.position)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, playerWaypoint.position, (2 * Time.deltaTime));
            yield return new WaitForSeconds(0.01f);
            Debug.Log("inside movement loop");
        }
        yield return new WaitForSeconds(1);
	}

	void Passing(){

	}

	void Shoot(int player){

	}

	void Block(){

	}












}
