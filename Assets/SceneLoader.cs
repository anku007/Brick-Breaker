using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            SceneManager.LoadScene("Level One");
        }

        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("Level Two");
        }

        if (Input.GetKey(KeyCode.C))
        {
            SceneManager.LoadScene("Level Three");
        }
    }
}
