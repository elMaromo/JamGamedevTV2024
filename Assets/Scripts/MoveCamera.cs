using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform placeStart;
    public Transform placeGame;
    public float timeToMove;

    // Start is called before the first frame update
    public void Start()
    {
        transform.DOMove(placeGame.position, timeToMove );
        transform.DORotate(placeGame.eulerAngles, timeToMove );
    }

    public void EndGame()
    {
        transform.DOMove(placeStart.position, timeToMove );
        transform.DORotate(placeStart.eulerAngles, timeToMove );
    }

    
}
