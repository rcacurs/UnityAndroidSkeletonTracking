using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour
{
	public float yaw;
	public float pitch;

	private Quaternion rotation;
	private Quaternion lookRot;
	private Vector3 position;

	public Transform target;

	private const float stiffness = 15;
	private const float distance = 3;

	void Awake()
	{
		The.gameCamera = this;

		rotation = Quaternion.Euler(-15, 180, 0);

		yaw = 200;
		pitch = 15;
	}

	void Update()
	{
		// Controls
		Controls();

		// Pitch limits
		pitch = Mathf.Clamp(pitch, -15, 75);

		// Assign values for rotation and position
		lookRot = Quaternion.Lerp(lookRot, Quaternion.Euler(pitch, yaw, 0), stiffness * Time.deltaTime);

		position = target.position + lookRot * new Vector3(0, 0, -distance); ;
		rotation = Quaternion.LookRotation(target.position - position, Vector3.up);
	}

	void Controls()
	{
		if (Input.GetMouseButton(0))
		{
			pitch -= Input.GetAxis("Mouse Y") * Settings.swipeSensitivity * Time.deltaTime;
			yaw += Input.GetAxis("Mouse X") * Settings.swipeSensitivity * Time.deltaTime;

			//Cursor.lockState = CursorLockMode.Locked;
			//Cursor.visible = false;
		}
		else
		{
			//Cursor.lockState = CursorLockMode.None;
			//Cursor.visible = true;
		}
	}

	void LateUpdate()
	{
		transform.rotation = rotation;
		transform.position = position;
	}
}
