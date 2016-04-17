using UnityEngine;
using System.Collections;

public class GameCharacter : MonoBehaviour
{
	public Transform head;
	public Transform hips;
	public Transform footLeft;
	public Transform footRight;

	public Transform footAnchorLeft;
	public Transform footAnchorRight;

	private Quaternion headRotation = Quaternion.identity;
	private Quaternion footRotation = Quaternion.identity;

	private Quaternion origFootRotationLeft;
	private Quaternion origFootRotationRight;

	private Vector3 origHipsPos;

	private float height;

	void Awake()
	{
		origFootRotationLeft = footLeft.rotation;
		origFootRotationRight = footRight.rotation;

		origHipsPos = hips.position;
	}

	void Update()
	{
		//transform.position = new Vector3(0, height, 0);
	}

	void LateUpdate()
	{
		head.transform.rotation = headRotation;
		footLeft.transform.rotation = origFootRotationLeft * footRotation;
		footRight.transform.rotation = origFootRotationRight * footRotation;

		/*if (footAnchorRight.position.y < footAnchorLeft.position.y)
		{
			height = -footAnchorRight.position.y;
		}
		else if ((footAnchorRight.position.y > footAnchorLeft.position.y))
		{
			height = -footAnchorLeft.position.y;
		}*/

		float feetDifference = Mathf.Abs(footAnchorRight.position.y - footAnchorLeft.position.y);

		if (footAnchorRight.position.y > 0 && footAnchorLeft.position.y > 0)
		{
			height = -feetDifference;
		}
		else
		{
			height = 0;
		}

		hips.position = origHipsPos + Vector3.up * height;
	}
}
