using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {



    void OnCollisionEnter()
    {

        Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
