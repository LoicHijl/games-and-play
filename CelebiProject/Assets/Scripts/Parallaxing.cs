using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {

    public Transform[] backgrounds;     // Array for backgrounds

    public float[] parallaxScales;  // Parallax strength
    public float smoothing = 0.5f;  // Parallax smoothing (Set > 0)

    public Transform cam;          // Reference main camera

    private Vector3 prevCamPos;     // Position of camera in previous frame

    // Before start, after assigning gameobjects. Great for references
    

	// Use this for initialization
	void Start () {
        prevCamPos = cam.position;

        parallaxScales = new float[backgrounds.Length];

        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (prevCamPos.x - cam.position.x) * parallaxScales[i];

            float backTargetX = backgrounds[i].position.x + parallax;

            Vector3 backgroundsTargetPos = new Vector3(backTargetX, backgrounds[i].position.y, backgrounds[i].position.z);

            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundsTargetPos, smoothing * Time.deltaTime);
        }

        // Set prevcam to campos
        prevCamPos = cam.position;
	}
}
