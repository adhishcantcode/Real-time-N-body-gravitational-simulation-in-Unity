# Unity N-Body Simulation (Entry Task + Prototype)

[![Simulation Demo](Images/demo.gif)](Images/demo3.mp4)

A real-time N-body gravitational simulation built in Unity to explore multi-body physics behavior, numerical stability, and visualization.  
This project serves as a proof-of-concept (POC) for the GSoC 2026 proposal:

**“AR Gravity & Planetary Physics Simulator.”**

---

## Overview

This repository demonstrates a real-time implementation of an **N-body gravitational system**, where multiple bodies interact through Newtonian physics.

The project highlights:

- Physics-based simulation of orbital motion
- Real-time performance in Unity
- Clear visualization of complex multi-body interactions

It forms the foundation for extending such simulations into **Augmented Reality (AR)** environments.

---

## Objective

Implement a real-time simulation where:

> Multiple celestial bodies interact under gravity and produce stable orbital motion

---

## Prototype Description

This Unity-based prototype demonstrates:

- Multi-body gravitational interaction (3–5 bodies)
- Central massive body (Sun) with orbiting planets
- Real-time orbital motion
- Stable simulation using numerical integration
- 3D orbital planes with slight tilt for depth
- Visual orbit trails using Trail Renderer

---

## Demo

[![Simulation Demo](Images/demo.mp4)
[![Simulation Demo](Images/demo3.mp4)

_Real-time multi-body gravitational simulation in Unity_

---

## Screenshots

![Simulation Demo](Images/img1.png)
![Simulation Demo](Images/img2.png)
![Simulation Demo](Images/img3.png)

---

## How It Works

1. Each body has:
   - Mass
   - Velocity
   - Position

2. At every physics step (`FixedUpdate`):
   - Forces between all bodies are computed
   - Acceleration is calculated
   - Velocity and position are updated

3. A **softening factor** is applied to:
   - Prevent instability at small distances
   - Avoid singularities in force calculation

---

## Physics Model

F = (G × m₁ × m₂) / r²

Where:

- G → Gravitational constant
- m₁, m₂ → Mass of bodies
- r → Distance between bodies

---

## Features Demonstrated

- Real-time N-body simulation
- O(n²) pairwise force computation
- Semi-implicit Euler integration
- Softening factor for stability
- Fixed timestep physics (`FixedUpdate`)
- 3D orbital motion (tilted planes)
- Orbit visualization using trails
- Clean and modular Unity implementation

---

## Technical Highlights

To ensure stability and correctness:

- Two-step update system (compute → apply)
- Softening factor to prevent infinite forces
- Fixed timestep for deterministic simulation
- Balanced accuracy and performance for real-time execution

---

## Tech Stack

- **Engine:** Unity
- **Language:** C#
- **Physics Model:** Newtonian Gravity
- **Update System:** Fixed timestep simulation

---

## Project Structure

Assets/ → Scripts, materials, scene files  
Packages/ → Unity dependencies  
ProjectSettings/ → Unity configuration  
Images/ → GIFs, screenshots, demo media

---

## How to Run

1. Clone the repository:

git clone https://github.com/adhishcantcode/Real-time-N-body-gravitational-simulation-in-Unity.git

2. Open the project in Unity
3. Open the main scene
4. Press Play

> Ensure Unity version compatibility and required packages are installed

---

## Related Work

- Python Entry Task (N-body Simulation):  
  https://github.com/adhishcantcode/N-Body-Gravitational-Simulation

- AR Planet Simulation (Unity):  
  https://github.com/adhishcantcode/AR-Planet-Simulation

---

## Future Scope (Proposal Alignment)

This prototype will be extended into a full AR system:

- AR integration using AR Foundation
- Real-world placement of planetary systems
- Advanced integration methods (Verlet)
- Performance optimization for larger systems
- Interactive controls (spawn, scale, reset)

---

## Author

**Adhish Gupta**

- GitHub: https://github.com/adhishcantcode

---

## Acknowledgment

This work is part of my application to the  
**International Catrobat Association – GSoC 2026**

---

## Notes for Evaluators

- Demonstrates **core N-body physics implementation**
- Focused on **stability, clarity, and real-time performance**
- Designed as a **direct foundation for AR-based simulation**
- Includes visualization improvements for intuitive understanding

---
