using UnityEngine;
using UnityEngine.InputSystem;

public class BallDropper : MonoBehaviour
{
    public GameObject BallPrefab;
    
    // Update is called once per frame
    void Update()
    {
        //checks if game has started and if left mouse button was pressed
        if (Game.IsGameStarted() && Mouse.current.leftButton.wasPressedThisFrame) 
        {
            dropBall(); // drops ball at a random position
        }
    }

    private void dropBall()
    {
        Vector3 spawnPosition = getSpawPosition(); // where to place ball
        
        GameObject ball = Instantiate(BallPrefab, spawnPosition, Quaternion.identity);

        AddRandomForce(ball);
    }

    private void AddRandomForce(GameObject ball)
    {
        Rigidbody2D rigidbody = ball.GetComponent<Rigidbody2D>();
        float randomXForce = Random.Range(-4f, 4f);
        rigidbody.AddForce(new Vector2(randomXForce, 0.0f), ForceMode2D.Impulse);
    }

    private Vector3 getSpawPosition()
    {
        Vector3 leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 rightEdge = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Camera.main.nearClipPlane));
        
        float ranXPos = Random.Range(leftEdge.x + 1, rightEdge.x - 1);
        
        Vector3 spawnPosition = new Vector3(ranXPos, 4.5f, 0f);
        return spawnPosition;
    }
}
