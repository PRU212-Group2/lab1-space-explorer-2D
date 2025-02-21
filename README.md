Here’s the corrected version with a proper table of contents that includes clickable links:

---

# Space Explorer 2D

**Space Explorer 2D** is an exciting space adventure game where the player controls a ship, dodges asteroids, collects stars, and shoots enemies for points. The game is designed with progressively difficult waves of asteroids, looping levels, and thrilling particle effects.

## Table of Contents
1. [Team Members](#team-members)
2. [Controls](#controls)
3. [Gameplay](#gameplay)
4. [Progression](#progression)
5. [Asteroid Spawning](#asteroid-spawning)
6. [Game Over](#game-over)
7. [Audio & Visual Effects](#audio--visual-effects)
8. [User Interface](#user-interface)
9. [Assets](#assets)
10. [Installation](#installation)

---

## Team Members
- **Lê Quang Khánh - SE182420**
- **Nguyễn Quang Khánh An - HE180905**
- **Nguyễn Phạm Đăng Quang - SE173601**
- **Võ Thị Thanh Tâm - QE180092**
- **Đào Trọng Đức - SE180110**

## Controls
- **Move:** `WASD` or arrow keys
- **Shoot:** Automatic firing

## Gameplay
- **Player Ship:**
  - Health: 100
  - Projectile Damage: 10
  - Health decreases on collision with asteroids, and score deducted equals the asteroid's damage.

![SpaceShip](Assets/3rd%20Party%20Assets/SpaceAssets/Ships/Spaceship.png)

- **Asteroids:**
  - **Asteroid 1:**
    - Damage: 10
    - Health: 30
    - Destroying it grants 50 points.
      
    ![Asteroid 1](Assets/3rd%20Party%20Assets/SpaceAssets/Asteroids/Asteroid_1.png)
  - **Asteroid 2:**
    - Damage: 30
    - Health: 50
    - Destroying it grants 70 points.
      
    ![Asteroid 2](Assets/3rd%20Party%20Assets/SpaceAssets/Asteroids/Asteroid_2.png)
  - **Asteroid 3:**
    - Damage: 50
    - Health: 70
    - Destroying it grants 100 points.
      
    ![Asteroid 3](Assets/3rd%20Party%20Assets/SpaceAssets/Asteroids/Asteroid_3.png)
    
- **Stars:**
  - **Yellow Star:** Collecting gives 150 points.
    
    ![Star 1](Assets/3rd%20Party%20Assets/SpaceAssets/Stars/Star_1.png)
  - **Red Star:** Collecting gives 300 points.
    
    ![Star 2](Assets/3rd%20Party%20Assets/SpaceAssets/Stars/Star_2.png)

## Progression
- As the player accumulates points (thresholds like 1000 or 2000), the scene flashes and transitions to the next level with more challenging asteroids and a unique space theme.
- The game loops through levels continuously as the player progresses.

## Asteroid Spawning
- **Trajectory:** Defined by path prefabs.
- **Waves:** Defined by scriptable objects, randomly spawning asteroids at specified intervals.
- **Spawning System:** A spawner prefab triggers waves with randomized time between waves.

## Game Over
- The player loses when their health reaches 0.

## Audio & Visual Effects
- **Particle Effects:**
  - Thrusters
  - Projectile hits
  - Explosions for asteroids and the player ship
- **Music:** Three looping tracks throughout gameplay.
- **Sound Effects:** 
  - Projectile hitting an asteroid
  - Asteroid hitting the player
  - Collecting a star

## User Interface
- **Main Menu:**
  - Start Game
  - Instructions
  - Quit
- **Game Over Screen:**
  - Displays final score
  - Options to restart, return to the main menu, or quit
- **Gameplay Screen:**
  - Health bar
  - Score counter

## Assets
- All game assets (sprites, textures) were generated using an AI-based pixelated workflow.

## Installation
1. Clone the repository:  
   ```bash
   git clone https://github.com/r1nzl3rrr/space-explorer-2D.git
   ```
2. Open the project in your preferred game engine (e.g., Unity).
3. Build and run the game!

Enjoy the game! 🚀

---
