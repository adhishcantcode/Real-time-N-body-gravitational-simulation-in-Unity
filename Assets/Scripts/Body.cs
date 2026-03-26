using UnityEngine;

/// <summary>
/// Represents a single body (planet, star, etc.) in the N-body simulation.
/// Stores physical properties like mass and velocity.
/// </summary>
public class Body : MonoBehaviour
{
    // Mass of the body (used in gravitational force calculations)
    public float mass = 1f;

    // Current velocity of the body (updated every physics step)
    public Vector3 velocity;
}