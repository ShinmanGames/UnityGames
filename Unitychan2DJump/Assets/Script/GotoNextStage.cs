using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class GotoNextStage : MonoBehaviour {

	[SceneName]
	public string stageName;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("Player")) {
			Application.LoadLevel(stageName);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
