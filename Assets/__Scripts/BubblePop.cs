using UnityEngine;

public class BubblePop : MonoBehaviour
{
    public float speed = 1f;  // how fast the bubble floats

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Missed bubble if it floats too high
        if (transform.position.y > 5)
        {
            ScoreManager.instance.MissBubble();
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        ScoreManager.instance.AddScore(1);
        Destroy(gameObject);
    }
}
