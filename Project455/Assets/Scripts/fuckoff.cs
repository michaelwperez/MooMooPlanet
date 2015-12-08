using UnityEngine;
using System.Collections;

public class fuckoff : MonoBehaviour {

	// Use this to quit the game
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
