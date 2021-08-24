using System;
using System.Collections.Generic;
using System.Text;

namespace BattleArena
{
    /// <summary>
    /// Represents any entity that exists in game
    /// </summary>
    struct Character
    {
        public string name;
        public float health;
        public float attackPower;
        public float defensePower;
    }

    class Game
    {
        bool gameOver;
        int currentScene;
        Character player;

        /// <summary>
        /// Function that starts the main game loop
        /// </summary>
        public void Run()
        {
            
        }

        /// <summary>
        /// Function used to initialize any starting values by default
        /// </summary>
        public void Start()
        {
           
        }

        /// <summary>
        /// This function is called every time the game loops.
        /// </summary>
        public void Update()
        {
            
        }

        /// <summary>
        /// This function is called before the applications closes
        /// </summary>
        public void End()
        {
            
        }

        /// <summary>
        /// Gets an input from the player based on some given decision
        /// </summary>
        /// <param name="description">The context for the input</param>
        /// <param name="option1">The first option the player can choose</param>
        /// <param name="option2">The second option the player can choose</param>
        /// <returns></returns>
        int GetInput(string description, string option1, string option2)
        {
            
        }
        
        /// <summary>
        /// Displays the menu that allows the player to start or quit the game
        /// </summary>
        void DisplayMainMenu()
        {
            
        }

        /// <summary>
        /// All code for the character selection screen should go here
        /// </summary>
        public void StartSceneCharacterSelection()
        {
            
        }

        /// <summary>
        /// All code for room 1 goes here
        /// </summary>
        public void StartSceneRoom1()
        {
            
        }

        /// <summary>
        /// All code for room 2 goes here
        /// </summary>
        public void StartSceneRoom2()
        {
            
        }

        /// <summary>
        /// All code for room 3 goes here
        /// </summary>
        public void StartSceneRoom3()
        {
           
        }

        /// <summary>
        /// Prints a characters stats to the console
        /// </summary>
        /// <param name="character">The character that will have its stats shown</param>
        void DisplayStats(Character character)
        {
            
        }

        /// <summary>
        /// Calculates the amount of damage that will be done to a character
        /// </summary>
        /// <param name="attackPower">The attacking character's attack power</param>
        /// <param name="defensePower">The defending character's defense power</param>
        /// <returns>The amount of damage done to the defender</returns>
        float CalculateDamage(float attackPower, float defensePower)
        {
            
        }

        /// <summary>
        /// Deals damage to a character based on an attacker's attack power
        /// </summary>
        /// <param name="attacker">The character that initiated the attack</param>
        /// <param name="defender">The character that is being attacked</param>
        /// <returns>The amount of damage done to the defender</returns>
        public float Fight(ref Character attacker, ref Character defender)
        {
            
        }

        /// <summary>
        /// Starts a battle between the player and the enemy.
        /// Characters fight until one has had its health reduced to zero.
        /// </summary>
        /// <param name="enemy">The enemy the player is going to fight</param>
        public void StartBattle(Character enemy)
        {
            
        }
    }
}
