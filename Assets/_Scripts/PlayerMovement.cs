using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public static int playerSpeed = 10;
    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.right * playerSpeed * Time.fixedDeltaTime);
    }
}
