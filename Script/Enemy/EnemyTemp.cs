using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyTemp : MonoBehaviour
{

    public GameObject EnemyT; // Makes the Enemy Sprite into an GameObject to be changed in script
    public Player damage; // Calls to the Player script with the variable damage.
    public float speed;
    public float health;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); // Sets the player as the target to find.
    }
    // Update is called once per frame

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > 1.5) // Limits the enemy from going into the same position as player.
            {
            // Moves the enemy into the position of the player.
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else // If the enemy is close and stops near the player, it will deal 20 damage to the player.
        {
            damage.PlayerTakeDamage(20); // Calls to Player script using the PlayerTakeDamage() function.
        }
    }

    void OnCollisionEnter2D(Collision2D collision) // Detects the collision with other objects.
    {

        health -= 1; // Decrements the Enemies health.
        if (health == 0) // States that if the health is 0, it will destroy the gameObject/Enemy.
        {
            Destroy(gameObject); // Destroys gameObject/Enemy
        }
    }
}