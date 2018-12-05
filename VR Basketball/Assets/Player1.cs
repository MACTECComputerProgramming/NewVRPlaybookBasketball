using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player1 : MonoBehaviour
{
    NavMeshAgent nm;
    public Transform[] P1T;
    public int currentLocation;
    public int nextLocation;
    // Use this for initialization
    void Start()
    {
        nm = this.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, P1T[currentLocation].position);
        if(/*distance from current location is small and button is clicked*/distance < 2)
        {
            Checkpointmove(currentLocation, nextLocation);
            currentLocation += 1;
            nm.SetDestination(P1T[currentLocation].position);
        }
        
    }

    private void Checkpointmove(int currentLocation, int nextLocation)
    {
        
        


    }
}
