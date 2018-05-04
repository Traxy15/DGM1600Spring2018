using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class musicPlayer : MonoBehaviour {

	private void Awake()
	{

		int numMusicPlayers = FindObjectsOfType<musicPlayer>().Length;
		if (numMusicPlayer > 1)
			{
				Destroy(gameObject);
			}
		//if more than one music player in scene
		// destroy ourselves
		else
		{
		DontDestroyOnLoad(gameObject);
		}
	}	
	
}
