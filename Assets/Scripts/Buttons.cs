using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public void LaunchGame()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (1);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
