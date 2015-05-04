using UnityEngine;
using System.Collections;

public class LoadingController : MonoBehaviour
{
    [SceneName]
    public string nextLevel;

	public Texture2D[] fadeImage;

    void Start()
    {
		Application.LoadLevel(nextLevel);
	}
}
