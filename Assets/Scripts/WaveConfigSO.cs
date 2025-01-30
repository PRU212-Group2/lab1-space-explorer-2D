using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] List<GameObject> asteroids;
    [SerializeField] Transform path;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float timeBetweenAsteroidSpawns = 1f;
    [SerializeField] float spawnTimeVariance = 0f;
    [SerializeField] float minimumSpawnTime = 0.2f;
    
    public int GetAsteroidCount()
    {
        return asteroids.Count;
    }

    public GameObject GetAsteroid(int index)
    {
        return asteroids[index];
    }

    public Transform GetStartingPoint()
    {
        // Return the transform of the first waypoint
        return path.GetChild(0);
    }
    
    // Get list of waypoints for path finding
    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = new List<Transform>();
        
        // For each child in the path add it to the waypoints list
        foreach (Transform waypoint in path)
        {
            waypoints.Add(waypoint);
        }
        
        return waypoints;
    }
    
    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public float GetRandomSpawnTime()
    {
        // Randomize the spawn time with spawn time variance
        float spawnTime = Random.Range(timeBetweenAsteroidSpawns - spawnTimeVariance, 
                                       timeBetweenAsteroidSpawns + spawnTimeVariance);
        
        // Making sure spawntime does not get below the minimum threshold
        return Mathf.Clamp(spawnTime, minimumSpawnTime, float.MaxValue);
    }
}
