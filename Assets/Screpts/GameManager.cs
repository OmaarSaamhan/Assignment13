using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        /*Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Omar", 90);
        player2.InitializePlayer("Ahmed", 70);

        player1.Heal(10);
        player2.Heal(30);

        player1.Heal(true);
        player2.Heal(true);

        Player.ShowPlayerCount();*/

        PlayerG player11 = new PlayerG();
        PlayerG player22 = new PlayerG();
        PlayerG player33 = new PlayerG();

        player11.InitializePlayer("Amin", 120);
        player22.InitializePlayer("Omar", 40);
        player33.InitializePlayer("Oday", -15);
        player11.ReLife();
        player22.ReLife();
        player33.ReLife();

    }
}
