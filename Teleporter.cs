using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public Transform exit;
    static Transform last;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (exit == last)
            return;

        TeleportToExit(other);
            }
    void OnTriggerExit2D()
    {
        if (exit == last)
            last = null;
    }
    void TeleportToExit (Collider2D other)
    {
        last = transform;
        other.transform.position = exit.transform.position;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
