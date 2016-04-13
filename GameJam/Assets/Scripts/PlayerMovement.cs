using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float _speed;
    public float _fallingSpeed;

	void Update () 
	{
        transform.position += new Vector3(0, -_fallingSpeed);


        if (this.gameObject.tag == "Player1")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                 {
                     transform.position -= new Vector3(_speed * Time.deltaTime, 0.0f, 0f);
                 }
            if (Input.GetKey(KeyCode.RightArrow))
                {
                     transform.position += new Vector3(_speed * Time.deltaTime, 0.0f, 0f);
                }
        }
        if (this.gameObject.tag == "Player2")
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(_speed * Time.deltaTime, 0.0f, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(_speed * Time.deltaTime, 0.0f, 0f);
            }
        }


	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "GoodBug")
        {
            _fallingSpeed = _fallingSpeed + 0.02f;
            Destroy(other.gameObject);

        }
        if (other.transform.tag == "BadBug")
        {
            _fallingSpeed = _fallingSpeed - 0.02f;
            Destroy(other.gameObject);

        }
    }
	
}