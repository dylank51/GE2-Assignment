using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	[SerializeField]
	private float delaybeforeloading = 10f;
	[SerializeField]
	private string sceneNameToLoad;
	
	private float TimeElapsed;
	
	
    void Update()
    {
        TimeElapsed += Time.deltaTime;
		if(TimeElapsed > delaybeforeloading)
		{
			SceneManager.LoadScene(sceneNameToLoad);
		}
    }
}