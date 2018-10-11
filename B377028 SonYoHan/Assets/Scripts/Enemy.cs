using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Transform target;
    public Vector3 direction;
    public float enemyspeed = 2.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveToTarget();
	}

    public void MoveToTarget()
    {
        target = GameObject.Find("Player").transform;
        direction = (target.position - transform.position).normalized;
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= 10.0f)
        {
            transform.Translate(enemyspeed * direction * Time.deltaTime);
        }
    }
}
