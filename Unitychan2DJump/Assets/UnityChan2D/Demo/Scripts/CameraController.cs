using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    public Transform target;
    public Transform stopPosition;

    private Camera m_camera;
	private Vector2 center; // 

    void Awake()
    {
        m_camera = GetComponent<Camera>();
		center = m_camera.ViewportToWorldPoint(Vector2.one * 0.5f);
	}
	
    void LateUpdate()
    {
    	var right = m_camera.ViewportToWorldPoint(Vector2.right);
		var pos = m_camera.transform.position;

		if (center.x < target.position.x) {
			if (Math.Abs (pos.x - target.position.x) >= 0.0000001f) {
				m_camera.transform.position = new Vector3 (target.position.x, pos.y, pos.z);
			}
		}

        if (stopPosition.position.x - target.position.x < 11.0)
        {
			var stop = pos;
			m_camera.transform.position = new Vector3 (stop.x, pos.y, pos.z);
        }

	}
}
