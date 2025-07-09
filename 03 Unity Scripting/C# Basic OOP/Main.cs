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
            return health -= amount;  
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
        private int score;

        public void ResetScore()
        {
            score = 0;
        }

        public int AddPoint(int Score)
        {
            if (Score > 0)
            {
                return score += Score;
            }
            else
            {
                return score;
            }
        }

    }

    class TreasureChest
    {
        public bool shake;
        public bool unlocked;

        public string Shake()
        {
            
            return("You hear something rattle inside the chest.");        }

        public virtual string Unlock()
        {
            return("");
        }
        //public virtual string Unlock(bool HasToken)
        //{
        //    if(HasToken == true)
        //    {
        //        return ("You got bonus loot!");
        //    } else
        //    {
        //        return Unlock();
        //    }
        //}
        public virtual string Bonus(bool HasToken)
        {
            if (HasToken == true)
            {
                return ("You got bonus loot!");
            }
            else
            {
                return Unlock();
            }
        }
    }
    class AncientChest : TreasureChest
        {
            public override string Bonus(bool HasToken)
        {
                    return("You unlock the ancient chest with an ancient key.");
                }
        
        }
    class MagicChest : TreasureChest
        {
            public override string Unlock()
                {
                    return ("You cast a spell to unlock the magic chest.");
                }
    }

    public class ScoreManager
    {
        private int score; // This is the total score for the whole game

        public void AddScore(int value)
        {
            score += value;
        }

        public int GetScore()
        {
            return score;
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
