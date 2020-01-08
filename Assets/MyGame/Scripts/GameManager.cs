using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform[] positions;
    [SerializeField] private Transform ball;
    [SerializeField] private bool positionRepeat = true;

    public void MoveBall ()
    {
        Vector3 newPos = positions[Random.Range(0, positions.Length)].position;
        Vector3 lastPos;

        do
        {
            lastPos = ball.position;
            ball.position = newPos;
            newPos = positions[Random.Range(0, positions.Length)].position;
        } 
        while (ball.position == lastPos && !positionRepeat);
    }

    public void SetRepeat(bool mode)
    {
        positionRepeat = mode;
    }
}
