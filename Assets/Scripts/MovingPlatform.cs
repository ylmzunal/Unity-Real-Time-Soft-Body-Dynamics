using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, 0, 5);
    public float speed = 1.0f;
    public float moveTime = 3.0f;

    void Start()
    {
        StartCoroutine(MoveBackAndForth());
    }

    IEnumerator MoveBackAndForth()
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + moveDirection;

        while (true)
        {
            yield return StartCoroutine(MovePlatform(startPosition, endPosition, moveTime));
            yield return StartCoroutine(MovePlatform(endPosition, startPosition, moveTime));
        }
    }

    IEnumerator MovePlatform(Vector3 start, Vector3 end, float time)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            transform.position = Vector3.Lerp(start, end, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = end;
    }
}

