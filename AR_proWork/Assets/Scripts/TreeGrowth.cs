using UnityEngine;

public class TreeGrowth : MonoBehaviour
{
    public float growthRate = 0.1f;   // Rate at which the tree grows
    public float maxScale = 10f;      // Maximum scale of the tree

    private float currentScale = 1f;   // Current scale of the tree

    void Update()
    {
        // Check if the tree has reached the maximum scale
        if (currentScale >= maxScale)
        {
            return;
        }

        // Increase the tree's scale over time
        currentScale += growthRate * Time.deltaTime;

        // Apply the new scale to the tree object
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }
}
