using UnityEngine;
using System.Collections.Generic;
// Uses semi-implicit Euler integration for updating motion
/// <summary>
/// Manages the N-body gravitational simulation.
/// Computes forces between all bodies and updates their motion in real-time.
/// </summary>
public class NBodySimulation : MonoBehaviour
{
    // List of all bodies (planets, sun, etc.) in the simulation
    public List<Body> bodies;

    // Gravitational constant (controls strength of attraction)
    public float G = 1f;

    // Softening factor to prevent extreme forces at very small distances
    public float softening = 0.1f;

    /// <summary>
    /// FixedUpdate is called at a fixed timestep (ideal for physics simulation)
    /// </summary>
    void FixedUpdate()
    {
        // Array to store computed accelerations for each body
        Vector3[] accelerations = new Vector3[bodies.Count];

        // -------- STEP 1: Compute forces and accelerations --------
        for (int i = 0; i < bodies.Count; i++)
        {
            Vector3 force = Vector3.zero;

            // Calculate force from every other body
            for (int j = 0; j < bodies.Count; j++)
            {
                // Skip self-interaction
                if (i == j) continue;

                // Direction vector from body i to body j
                Vector3 dir = bodies[j].transform.position - bodies[i].transform.position;

                // Distance between bodies (with softening to avoid division by zero)
                float dist = dir.magnitude + softening;

                // Newton's Law of Gravitation:
                // F = G * (m1 * m2) / r^2
                float forceMag = G * (bodies[i].mass * bodies[j].mass) / (dist * dist);

                // Add force contribution (direction normalized)
                force += dir.normalized * forceMag;
            }

            // Convert force to acceleration: a = F / m
            accelerations[i] = force / bodies[i].mass;
        }

        // -------- STEP 2: Apply velocity and position updates --------
        for (int i = 0; i < bodies.Count; i++)
        {
            // Optional: Keep first body (Sun) fixed in place
            if (i == 0) continue;

            // Update velocity: v = v + a * dt
            bodies[i].velocity += accelerations[i] * Time.fixedDeltaTime;

            // Update position: x = x + v * dt
            bodies[i].transform.position += bodies[i].velocity * Time.fixedDeltaTime;
        }
    }
}