using UnityEngine;
using UnityEngine.AI;

public class AddNavMeshObstacleToTrees : MonoBehaviour
{

    void Start()
    {
        Terrain terrain = GetComponent<Terrain>();

        if (terrain == null)
        {
            Debug.LogError("Terrain component not found.");
            return;
        }

        TreeInstance[] treeInstances = terrain.terrainData.treeInstances;
        for (int i = 0; i < treeInstances.Length; i++)
        {
            TreeInstance treeInstance = treeInstances[i];

            GameObject treeGameObject = new GameObject("Tree");

            treeGameObject.transform.position = Vector3.Scale(treeInstance.position, terrain.terrainData.size) + terrain.transform.position;

            NavMeshObstacle navMeshObstacle = treeGameObject.AddComponent<NavMeshObstacle>();
            navMeshObstacle.carving = true; // Enable carving

            // (Optional)
            // Set properties for the NavMeshObstacle (customize as needed)
            // For example, you might want to adjust the radius and height
            // navMeshObstacle.shape = NavMeshObstacleShape.Capsule;
            // navMeshObstacle.radius = 1.0f; // Set your desired radius
            // navMeshObstacle.height = 5.0f; // Set your desired height
            // navMeshObstacle.carving = true; // Enable carving

            // (Optional)
            // Attach the tree game object to the terrain
            // treeGameObject.transform.parent = terrain.transform;
        }
    }
}
