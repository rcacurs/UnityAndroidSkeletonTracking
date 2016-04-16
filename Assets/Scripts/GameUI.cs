using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour
{
	public GameObject mainMenuUI;
	public GameObject trainingUI;
	public GameObject mocapUI;

	void Awake()
	{
		The.gameUI = this;
	}

	void Start()
	{
		if (The.sceneLogic.type == SceneLogic.SceneType.MainMenu)
		{
			SwitchMainMenuUI();
		}
		else if (The.sceneLogic.type == SceneLogic.SceneType.Training)
		{
			SwitchTrainingUI();
		}
		else if (The.sceneLogic.type == SceneLogic.SceneType.Mocap)
		{
			SwitchMocapUI();
		}
	}

	public void HomeButton()
	{
		The.gameLogic.GotoMainMenu();
	}

	public void TrainingButton()
	{
		The.gameLogic.GotoTraining();
	}
	public void MocapButton()
	{
		The.gameLogic.GotoMocap();
	}

	void SwitchMainMenuUI()
	{
		mainMenuUI.SetActive(true);
		trainingUI.SetActive(false);
		mocapUI.SetActive(false);
	}
	void SwitchTrainingUI()
	{
		mainMenuUI.SetActive(false);
		trainingUI.SetActive(true);
		mocapUI.SetActive(false);
	}
	void SwitchMocapUI()
	{
		mainMenuUI.SetActive(false);
		trainingUI.SetActive(false);
		mocapUI.SetActive(true);
	}
}
