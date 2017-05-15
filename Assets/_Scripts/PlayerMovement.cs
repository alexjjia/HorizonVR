using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject headset;
    public float playerSpeed; //player's movement speed.
	public float speedFactor; //multiplicative factor that is applied to the playerSpeed by intervals dictated by speedInterval.
	public int speedInterval; //time in seconds for which the playerSpeed will multiplied by the speedFactor.

	private float timestamp; //used to keep track of time.

	/**
	 * Initial value declarations.
	 **/
	void Start()
	{
		//NOTE: VALUES BELOW SUBJECT TO CHANGE.
		playerSpeed = 10f; //initial speed. Will gradually increment by speedFactor every speedInterval.
		speedFactor = 1.10f;
		speedInterval = 10;

		timestamp = speedInterval;
	}

	// FixedUpdate() is called once per frame. It is preferred over Update() because the latter is not as predictable.
    void FixedUpdate()
    {
		if (Time.time >= timestamp) {
			playerSpeed = playerSpeed * speedFactor;
			//Debug.Log ("BING!");	//DEBUGGING PURPOSES.
			timestamp = Time.time + speedInterval;
		}
		
		transform.position += headset.transform.forward * playerSpeed * Time.deltaTime;
    }
}