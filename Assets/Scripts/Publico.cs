using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Publico : MonoBehaviour
{
    public float minTimeToMove;
    public float maxTimeToMove;
    public float moveAmount;
    public float moveDuration;

    private float currTimeToMove;
    private float counterToMove;

    public void Start()
    {
        currTimeToMove = Random.Range(minTimeToMove, maxTimeToMove);
        counterToMove = 0;
    }

    public void Update()
    {
        counterToMove += Time.deltaTime;

        if (counterToMove > currTimeToMove)
        {
            currTimeToMove = Random.Range(minTimeToMove, maxTimeToMove);
            counterToMove = 0;
            makeAnimation();
        }
    }

    public void makeAnimation()
    {
        transform.DOMoveY(moveAmount, moveDuration).SetLoops(2, LoopType.Yoyo);
        //transform.DOLocalJump(transform.position, moveAmount, 1, moveDuration);
    }
}
