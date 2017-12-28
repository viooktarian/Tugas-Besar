using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[SerializeField] Transform Target;
	[SerializeField] float followSpeed;
	Vector3 offset;

	void Start(){
		offset = Target.position - transform.position;
	}

	void FixedeUpdate(){
		transform.position = Vector3.Lerp (transform.position, Target.position - offset, Time.fixedDeltaTime * followSpeed);
	}
}
