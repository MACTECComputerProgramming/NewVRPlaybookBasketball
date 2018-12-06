using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TheFistScript : MonoBehaviour {


	public GameObject playerOne;
	public GameObject playerView;


	public Transform[] waypointsPlayer1;
	public int playerID;
	protected int actionValue;

	// Use this for initialization
	void Start () {		
		if(true /*PlayerNumber == 1*/){
			playerView.transform.parent = playerOne.transform;

		}

	}
	
	// Update is called once per frame
	void Update () {












	}










	public void NextAction()
	{
		actionValue ++;
		if(actionValue == 1)
		{
			// If (PlayerNumber == 1){Shoot(shooter, layup or not, ball position)}
			//NextMovement(actionValue, waypointsPlayer1, nm1);

		}
		if(actionValue == 2)
		{
			Shoot (1);
		}
		if(true)
		{
			
		}




	}


	void NextMovement(int stepNumber, Transform[] playerWaypoints, NavMeshAgent nmp)
	{
		//nmp.SetDestination (playerWaypoints[stepNumber].transform);
	}

	void Passing(){

	}

	void Shoot(int player){

	}

	void Block(){

	}












}
