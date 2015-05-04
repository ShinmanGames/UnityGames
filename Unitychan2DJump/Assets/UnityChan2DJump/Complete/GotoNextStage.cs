using UnityEngine;
using System.Collections;

namespace UnityChan2DJump
{
	[RequireComponent(typeof(BoxCollider2D))]
	public class GotoNextStage : MonoBehaviour
	{

		[SceneName]
		public string
			stageName;
	
		void OnTriggerEnter2D (Collider2D coll)
		{
			if (coll.gameObject.CompareTag ("Player")) {
				Application.LoadLevel (stageName);
			}
		}
	}
}