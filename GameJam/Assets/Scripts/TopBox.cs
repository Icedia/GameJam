using UnityEngine;
using System.Collections;

public class TopBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.transform.tag == "Goodbug")
        {
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "Badbug")
        {
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
