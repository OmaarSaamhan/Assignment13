using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int healthy;

    public static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        healthy = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        healthy += amount;
        Debug.Log(healthy);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            healthy = 100; 
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
