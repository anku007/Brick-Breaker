using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {

    public Rigidbody2D rb; 
    public float ballForce;
    bool gameStarted = false;
    public UIManager ui;

	// Use this for initialization
	void Start () {
        ui = GameObject.FindWithTag("UI").GetComponent<UIManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {
            transform.SetParent(null);
            rb.isKinematic = false;

            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            ui.gameOver();
        }
            
    }

}
