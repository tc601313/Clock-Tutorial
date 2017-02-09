using UnityEngine;
using System.Collections;
using System;

public class clock : MonoBehaviour 
{
	public GameObject hourHand;
	public GameObject minuteHand;
	public GameObject secondHand;

	void Update()
	{
		// get current time
		DateTime time = DateTime.Now;

		// set the second hand root
		int seconds = time.Second;

		// map seconds (0-60) to a rotation (0-360)
		float seconds_normalized = seconds / 60f ;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;

		// { x, y, z }
		Vector3 secondsRotation = new Vector3(0f, 0f, clockwise_seconds);
		Quaternion secondsRotationQuat = Quaternion.Euler (secondsRotation);
		secondHand.transform.rotation = secondsRotationQuat;

		int minute = time.Minute;

		// map minutes (0-60) to a rotation (0-360)
		float minute_normalized = minute / 60f ;
		float minute_degrees = minute_normalized * 360f;
		float clockwise_minute = 360f - minute_degrees;

		// { x, y, z }
		Vector3 minuteRotation = new Vector3(0f, 0f, clockwise_minute);
		Quaternion minuteRotationQuat = Quaternion.Euler (minuteRotation);
		minuteHand.transform.rotation = minuteRotationQuat;

		int hour = time.Hour;	

		// map minutes (0-60) to a rotation (0-360)
		float hour_normalized = hour / 12f ;
		float hour_degrees = hour_normalized * 360f;
		float clockwise_hour = 360f - hour_degrees;

		// { x, y, z }
		Vector3 hourRotation = new Vector3(0f, 0f, clockwise_hour);
		Quaternion hourRotationQuat = Quaternion.Euler (hourRotation);
		hourHand.transform.rotation = hourRotationQuat;
	}
}

