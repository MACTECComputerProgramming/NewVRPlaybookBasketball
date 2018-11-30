using UnityEngine;
using UnityEngine.AI;


public class Waypoints : MonoBehaviour
{

    NavMeshAgent nm;

    public Transform[] Waypoint;
    public int cur_loc;
    public float stop_distance;


    // Use this for initialization

    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.stoppingDistance = stop_distance;
    }


    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(transform.position, Waypoint[cur_loc].position);
        
        // incrementing waypoint value
        if (distance <= 2)
        {
            cur_loc += 1;
        }

        // stop script
        if (cur_loc >= Waypoint.Length)
        {
            
        }

        
        //Movement
        if (cur_loc == 0)
        {
            nm.SetDestination(Waypoint[0].position);
        }
    
        if (cur_loc == 1)
        {
            nm.SetDestination(Waypoint[1].position);
        }

        if (cur_loc == 2)
        {
            nm.SetDestination(Waypoint[2].position);
        }

        if (cur_loc == 3)
        {
            nm.SetDestination(Waypoint[3].position);
        }
        if (cur_loc == 4)
        {
            nm.SetDestination(Waypoint[4].position);
        }

        if (cur_loc == 5)
        {
            nm.SetDestination(Waypoint[5].position);
        }

        if (cur_loc == 6)
        {
            nm.SetDestination(Waypoint[6].position);
        }

        if (cur_loc == 7)
        {
            nm.SetDestination(Waypoint[7].position);
        }
        if (cur_loc == 8)
        {
            nm.SetDestination(Waypoint[8].position);
        }

        if (cur_loc == 9)
        {
            nm.SetDestination(Waypoint[9].position);
        }

        if (cur_loc == 10)
        {
            nm.SetDestination(Waypoint[10].position);
        }

        if (cur_loc == 11)
        {
            nm.SetDestination(Waypoint[11].position);
        }
        if (cur_loc == 12)
        {
            nm.SetDestination(Waypoint[12].position);
        }

        if (cur_loc == 13)
        {
            nm.SetDestination(Waypoint[13].position);
        }

        if (cur_loc == 14)
        {
            nm.SetDestination(Waypoint[14].position);
        }

        if (cur_loc == 15)
        {
            nm.SetDestination(Waypoint[15].position);
        }
        if (cur_loc == 16)
        {
            nm.SetDestination(Waypoint[17].position);
        }

        if (cur_loc == 18)
        {
            nm.SetDestination(Waypoint[18].position);
        }

        if (cur_loc == 19)
        {
            nm.SetDestination(Waypoint[19].position);
        }

        if (cur_loc == 20)
        {
            nm.SetDestination(Waypoint[20].position);
        }

    }
}