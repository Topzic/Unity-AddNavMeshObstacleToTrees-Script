# Unity AddNavMeshObstacleToTrees Script

## Overview

This Unity script simplifies the process of adding NavMeshObstacle components to trees in a Unity terrain. By attaching this script to an object in your scene, you can automatically create NavMeshObstacle components for each tree, enabling them to act as obstacles within the Unity Navigation system (NavMesh).

## Instructions

1. **Attach Script**: Attach the `AddNavMeshObstacleToTrees` script to a GameObject in your Unity scene.

2. **Assign Terrain**: In the Inspector, select the GameObject with the script and assign the Unity Terrain to the `Terrain` field.

3. **Tree Colliders**: Ensure that the tree prefabs (defined as tree prototypes in the terrain settings) have either a `CapsuleCollider` or `BoxCollider` component attached to them. This is a prerequisite for the script to work correctly.

## Optional Customization

If needed, you can customize the NavMeshObstacle components by adjusting their properties. For example, you can modify the shape, radius, and height.

```csharp
// (Optional)
// Set properties for the NavMeshObstacle (customize as needed)
// For example, you might want to adjust the radius and height
// navMeshObstacle.shape = NavMeshObstacleShape.Capsule;
// navMeshObstacle.radius = 1.0f; // Set your desired radius
// navMeshObstacle.height = 5.0f; // Set your desired height
// navMeshObstacle.carving = true; // Enable carving
```

```csharp
Optional Parenting
If desired, you can attach the newly created tree GameObjects to the terrain to maintain a clean hierarchy.
// (Optional)
// Attach the tree game object to the terrain
// treeGameObject.transform.parent = terrain.transform;
```

## Important Notes
Clean-Up: After adding the NavMeshObstacle components to your trees, it's important to remove the AddNavMeshObstacleToTrees script component from the GameObject. Leaving the script attached may lead to duplicate obstacles being created if the script is run again.

Performance Considerations: Be mindful of performance when using this script, especially in scenes with a large number of trees. Balancing gameplay requirements with performance optimization is crucial when implementing navigation and collision features.

This script streamlines the process of integrating trees as NavMesh obstacles in Unity, helping you create more dynamic and interactive game worlds.
