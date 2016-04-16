using UnityEngine;
using System.Collections;

public class SceneLogic : MonoBehaviour
{
	public enum SceneType
	{
		MainMenu,
		Mocap,
		Training,
	}

	public SceneType type;

	void Awake()
	{
		The.sceneLogic = this;
	}
}
