using UnityEngine;

public class TreeGrowth : MonoBehaviour
{
    public float growthRate = 0.1f;       // Rate at which the tree grows
    public float maxScale = 10f;          // Maximum scale of the tree
    public float minScale = 1f;           // Minimum scale of the tree
    public float scaleChangeDirection = 1f;   // Scaling direction (1 for increasing, -1 for decreasing)
    public float delayDuration = 1f;

    private float currentScale = 1f;       // Current scale of the tree
    private float delayTimer = 0f;                 // Timer to track the delay duration

    void Update()
    {
        if (delayTimer > 0f)
        {
            // If in delay period, increment the timer
            delayTimer -= Time.deltaTime;
            return;
        }

        // Increase or decrease the tree's scale over time
        currentScale += scaleChangeDirection * growthRate * Time.deltaTime;

        // Check if the scale exceeds the limits
        if (currentScale >= maxScale)
        {
            currentScale = maxScale;
            scaleChangeDirection = -1f; // Reverse the scale change direction

            // Start the delay timer
            delayTimer = delayDuration;
        }
        else if (currentScale <= minScale)
        {
            currentScale = minScale;
            scaleChangeDirection = 1f;  // Reverse the scale change direction
        }

        // Apply the new scale to the tree object
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }
}
