using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip music;

	void Start () 
	{

		var audioSource = MusicController.Instance.audio;
		if( audioSource.clip != music )
		{
			audioSource.clip = music;
			audioSource.Play();
		}
	}
}
