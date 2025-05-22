using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    class Projectile
    {
        private float speed;
        public string Fire()
        {
            if(speed > 0)
            {
                return("Firing projectile a Speed: " + speed);
            }
            else
            {
                print("Cannot fire: speed too low.");
                 return AutoFire();
            }
            
        }
        public string AutoFire()
        {
            speed = 100;
            return("Speed was zero. AutoFire set speed to 100 and launched!");
        }
    }
    public class Player
    {
        private int health;

        public int TakeDamage(int amount)
        {
            return health = health - amount;  
        }
        public int GetHealth()
        {
            return health;
        }
        public int Health()
        {
            return health = 100;
        }
    }
    public class ScoreTracker
    {
        public int score;

        public void ResetScore()
        {
            score = 0;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
    
        //Player player = new Player(10);
        //player.TakeDamage(3);
        

    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
