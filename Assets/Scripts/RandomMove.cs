using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
	public float speed = 1;
	public float rotate_interval = 10;
	public float facing_change_max = 30;

	float facing;
	Vector3 randomRotate;

	void Start()
	{
		facing = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, facing, 0);
		NewFacingRoutine();
	}

	void Update()
	{
		NewFacingRoutine();
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, randomRotate, Time.deltaTime * rotate_interval);
		transform.position += transform.forward * Time.deltaTime * 1.0f;
	}



	void NewFacingRoutine()
	{
		var mini = Mathf.Clamp(facing - facing_change_max, 0, 360);
		var maxi = Mathf.Clamp(facing + facing_change_max, 0, 360);
		facing = Random.Range(mini, maxi);
		randomRotate = new Vector3(0, facing, 0);
	}
}