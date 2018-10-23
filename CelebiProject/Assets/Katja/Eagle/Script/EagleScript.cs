using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleScript : MonoBehaviour {
    timeStatesScript timeStateScript;
    public int timeState;
    public int t;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
    }
	
	// Update is called once per frame
	void Update () {
        //update timecount
        t += 1;

        //get timestate variable from timestates script
        timeStateScript = GetComponent<timeStatesScript>();
        timeState = timeStateScript.timeState;

        //check whether it is in the egg state or the bird state
        if (timeState == 1) {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            GetComponent<Rigidbody2D>().velocity *= new Vector2(0, 1);
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            
            //standard movement
            if (t == 200)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
                transform.rotation = Quaternion.Euler(0, 180f, 0);
            }
            else if (t == 400)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                t = 0;
            }
        }
    }
}
