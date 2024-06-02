using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RotatateSpotliht : MonoBehaviour
{
    public float rotateAngle = 45f; // The angle by which the spotlight will rotate
    public float duration = 1f; // Duration of one back and forth rotation

    private void Start()
    {
        // Start the rotation back and forth
        RotateBackAndForth();
    }

    private void RotateBackAndForth()
    {
        // Define the rotation angles
        float startYAngle = transform.eulerAngles.y;
        float endYAngle = startYAngle + rotateAngle;

        // Create a sequence for the rotation
        Sequence rotationSequence = DOTween.Sequence();

        // Add the rotation to the sequence
        rotationSequence.Append(DORotateY(endYAngle, duration).SetEase(Ease.InOutSine))
                        .Append(DORotateY(startYAngle, duration).SetEase(Ease.InOutSine))
                        .SetLoops(-1, LoopType.Restart); // Loop indefinitely
    }

    private Tween DORotateY(float endValue, float duration)
    {
        // Create a tween for rotating only the Y axis
        return DOTween.To(() => transform.eulerAngles.y, 
                          y => transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.eulerAngles.z), 
                          endValue, 
                          duration);
    }
}
