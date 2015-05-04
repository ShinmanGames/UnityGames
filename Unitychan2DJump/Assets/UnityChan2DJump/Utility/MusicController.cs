using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MusicController : SingletonMonoBehaviourFast<MusicController>
{
	public AudioSource audioSource{ get; private set;}

	void Start()
	{
		DontDestroyOnLoad(gameObject);
		audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}

	void OnDestroy ()
	{
		Destroy(gameObject);	
	}
}
