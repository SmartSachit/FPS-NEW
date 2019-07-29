using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
 
	public void ControlMenu()
	{
		SceneManager.LoadScene(sceneBuildIndex:4);
	}

	public void BackToMainMenu ()
	{
		SceneManager.LoadScene(sceneBuildIndex:1);
	}

}
