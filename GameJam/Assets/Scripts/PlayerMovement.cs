using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float _speed;
    public float _fallingSpeed;

	void Update () 
	{
        transform.position += new Vector3(0, -_fallingSpeed);


		if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.position -= new Vector3 (_speed * Time.deltaTime, 0.0f, 0f);

		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.position += new Vector3 (_speed * Time.deltaTime, 0.0f, 0f);
		}

	}
    void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "GoodBug")
        {
            _fallingSpeed = _fallingSpeed + 0.5f;
            Destroy(other.gameObject);

        }
        if (other.transform.tag == "BadBug")
        {
            _fallingSpeed = _fallingSpeed - 0.5f;
            Destroy(other.gameObject);

        }
    }
	
}