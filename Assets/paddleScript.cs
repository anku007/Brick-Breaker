using UnityEngine;
using System.Collections;

public class paddleScript : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public float maxX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");

        if(x < 0)
        {
            moveLeft();
        }

        if(x > 0)
        {
            moveRight();
        }

        if(x == 0)
        {
            Stop();
        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
	}

    void moveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    void moveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void Stop()
    {
        rb.velocity = Vector2.zero; 
    }
}
