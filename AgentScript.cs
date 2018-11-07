    using UnityEngine;
    using UnityEngine.AI;
    using System.Collections;


    public class AgentScript : MonoBehaviour {

        public Transform[] points;
        private int destPoint = 0;
        private NavMeshAgent agent;


        void Start () {
            agent = GetComponent<NavMeshAgent>();

            agent.autoBraking = false;

            GotoNextPoint();
        }


        void GotoNextPoint() {
            if (points.Length == 0)
                return;

            agent.destination = points[destPoint].position;

            // Choose the next point in the array as the destination,
            // cycling to the start if necessary.
            destPoint = (destPoint + 1) % points.Length;
        }


        void Update () {
            // Choose the next destination point when the agent gets
            // close to the current one.
            if (!agent.pathPending && agent.remainingDistance < 0.2f)
		destPoint;
                GotoNextPoint();
        }
    }