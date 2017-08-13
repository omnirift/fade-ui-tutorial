using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader : MonoBehaviour {

    private void Start()
    {
        
    }

    public IEnumerator Lerp(float start, float end, float lerpTime = 1)
	{
		float _timeStartedLerping = Time.time;
		float timeSinceStarted = Time.time - _timeStartedLerping;
		float percentageComplete = timeSinceStarted / lerpTime;

		while (true)
		{
			timeSinceStarted = Time.time - _timeStartedLerping;
			percentageComplete = timeSinceStarted / lerpTime;

			float currentValue = Mathf.Lerp(start, end, percentageComplete);

            if (percentageComplete >= 1) break;

			yield return new WaitForFixedUpdate();
		}
	}
}
