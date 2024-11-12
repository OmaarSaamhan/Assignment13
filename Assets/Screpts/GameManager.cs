using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player1 = new  Player();
        Player player2 = new  Player();

        player1.InitializePlayer("Omar", 90);
        player2.InitializePlayer("Ahmed", 70);

        player1.Heal(10);
        player2.Heal(30);

        player1.Heal(true);
        player2.Heal(true);

        Player.ShowPlayerCount();
        
    }
}
