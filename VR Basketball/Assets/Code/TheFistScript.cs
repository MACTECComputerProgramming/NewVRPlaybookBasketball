using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFistScript : MonoBehaviour {


	public GameObject[] players;
	public GameObject playerView;
    public GameObject capsule;
    public Transform[] playerWaypoints;

    public int playerID;
	public int actionValue;
    public int playNum;

	
	void Start () {	
        //playNum = value from luke;
		if(true /*playNum == el fist*/){

            //set blocks to start positions
            players[0].transform.position = new Vector3(2, 2, 1);
            players[1].transform.position = new Vector3(-3.5f, 2, 5.5f);
            players[2].transform.position = new Vector3(4, 2, 6);
            players[3].transform.position = new Vector3(-2, 2, 2);
            players[4].transform.position = new Vector3(0, 2, 5.5f);

            //set waypoints to first waypoint
            SetWaypointLocation(playerWaypoints[0], new Vector3(1.5f, 1, 8));
            SetWaypointLocation(playerWaypoints[1], new Vector3(-2.5f, 1, 6));
            SetWaypointLocation(playerWaypoints[2], new Vector3(0.5f, 1, 8.5f));
            SetWaypointLocation(playerWaypoints[3], new Vector3(-2, 1, 5.5f));
            SetWaypointLocation(playerWaypoints[4], new Vector3(1, 1, 4));


            //playerID = value from luke;
        }
        if(false /*scenenumber == circle*/)
        {

        }






        switch (playerID)
        {
            case 0:
                SetPlayerNumber(0);
                break;
            case 1:
                SetPlayerNumber(1);
                break;
            case 2:
                SetPlayerNumber(2);
                break;
            case 3:
                SetPlayerNumber(3);
                break;
            case 4:
                SetPlayerNumber(4);
                break;
        }

    }
	
    
    //Called from capsule
	public void NextAction()
	{
		actionValue ++;
        if (actionValue == 1)
        {
            //Moving players
            StartCoroutine(NextMovement(actionValue, playerWaypoints[0], players[0]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[1], players[1]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[2], players[2]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[3], players[3]));
            StartCoroutine(NextMovement(actionValue, playerWaypoints[4], players[4]));
            Block(1);
            Block(3);
            Block(4);
            //Moving UI capsule
            capsule.transform.position = playerWaypoints[playerID].transform.position;
        }

        
		if(actionValue == 2)
		{
            if (playerID == 1)
            {
                Shoot(1);
            }
            else
            {
                Block(1);
                Block(3);
                StartCoroutine(NextMovement(actionValue, playerWaypoints[2], players[2]));
                StartCoroutine(NextMovement(actionValue, playerWaypoints[4], players[4]));



            }





		}
		if(true)
		{
			
		}




	}


	public IEnumerator NextMovement(int stepNumber, Transform playerWaypoint, GameObject player)
	{
        
        while (player.transform.position != playerWaypoint.position)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, playerWaypoint.position, (2 * Time.deltaTime));
            yield return new WaitForSeconds(0.01f);
            
        }
        yield return new WaitForSeconds(1);
	}

	void Passing(){

	}

	void Shoot(int player){

	}

	void Block(int player){

	}


    void SetPlayerNumber(int playerNum)
    {
        playerView.transform.position = new Vector3(players[playerNum].transform.position.x, players[playerNum].transform.position.y + 1, players[playerNum].transform.position.z);
        playerView.transform.parent = players[playerNum].transform;
        capsule.transform.position = playerWaypoints[playerNum].transform.position;
    }

    void SetWaypointLocation(Transform playerWaypoint, Vector3 newLocation)
    {
        playerWaypoint.position = newLocation;
    }







}
