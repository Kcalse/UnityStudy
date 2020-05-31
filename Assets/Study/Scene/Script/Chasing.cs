using UnityEngine;
using System.Collections;

public class Chasing : MonoBehaviour {
    private Transform pursuertr;
    private Transform playertr;
    private NavMeshAgent nvAgent;


	// Use this for initialization
	void Start () {
        pursuertr = gameObject.GetComponent<Transform>();
        playertr = GameObject.FindWithTag("Player").GetComponent<Transform>();

        nvAgent = gameObject.GetComponent<NavMeshAgent>();
	
	}
	
	// Update is called once per frame
	void Update () {
        nvAgent.destination = playertr.position;
    }
}
