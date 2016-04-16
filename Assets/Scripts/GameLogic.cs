using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameLogic : MonoBehaviour
{
	void Awake()
	{
		if (!The.gameLogic)
		{
			The.gameLogic = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void GotoMainMenu()
	{
		LoadScene("MainMenu");
		The.sceneName = "MainMenu";
	}
	public void GotoMocap()
	{
		LoadScene("Mocap");
		The.sceneName = "Mocap";
	}
	public void GotoTraining()
	{
		LoadScene("Training");
		The.sceneName = "Training";
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
