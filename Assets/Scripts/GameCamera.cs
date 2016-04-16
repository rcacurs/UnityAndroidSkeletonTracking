using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour
{
	public float yaw;
	public float pitch;

	private Quaternion rotation;
	private Vector3 position;

	public Transform target;

	void Update()
	{


		// Pitch limits
		pitch = Mathf.Clamp(pitch, -15, 75);

		// Assign values for rotation and position
		Quaternion targRot = Quaternion.Euler(pitch, yaw, 0);
		rotation = Quaternion.Lerp(rotation, targRot, 15 * Time.deltaTime);

		Vector3 offset = new Vector3(0,0,-3);
		Vector3 targPos = target.position + rotation * offset;
		position = Vector3.Lerp(position, targPos, 15 * Time.deltaTime);
	}

	void LateUpdate()
	{
		transform.rotation = rotation;
		transform.position = position;
	}
}
