using UnityEngine;

public class BubblePop : MonoBehaviour
{
    public float speed = 1f;  // how fast it floats up
    public int scoreValue = 1;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Destroy if it floats too high
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Pop!");
        ScoreManager.instance.AddScore(scoreValue);
        Destroy(gameObject);
    }
}