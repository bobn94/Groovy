using UnityEngine;
using System.Collections;

public class LP : MonoBehaviour {
	private Vector3 Rot;
	public GameObject Obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rot.x = 0.0f;
		Rot.y = 0.0025f;
		Rot.z = 0.0f;
		iTween.RotateBy(Obj, Rot, 0.0f);
	}
}
