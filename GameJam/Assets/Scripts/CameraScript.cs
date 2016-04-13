using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
    public Transform player1;
    public Transform player2;

    private const float FOV_MARGIN = 15.0f;

    private Vector3 middlePoint;
    private float distanceFromMiddlePoint;
    private float distanceBetweenPlayers;
    private float aspectRatio;
    public float _fallingSpeed;

    void Start()
    {
        aspectRatio = Screen.width / Screen.height;
    }

    void Update()
    {
        transform.position += new Vector3(0, -_fallingSpeed);
        // Find the middle point between players.
        middlePoint = player1.position + 0.5f * (player2.position - player1.position);

        // Position the camera in the center.
        Vector3 newCameraPos = Camera.main.transform.position;
        newCameraPos.x = middlePoint.x;
        Camera.main.transform.position = newCameraPos;

        // Calculate the new FOV.
        distanceBetweenPlayers = (player2.position - player1.position).magnitude;
        distanceFromMiddlePoint = (Camera.main.transform.position - middlePoint).magnitude;
        Camera.main.fieldOfView = 2.0f * Mathf.Rad2Deg * Mathf.Atan((0.5f * distanceBetweenPlayers) / (distanceFromMiddlePoint * aspectRatio));

        // Add small margin so the players are not on the viewport border.
        Camera.main.fieldOfView += FOV_MARGIN;
    }
}
