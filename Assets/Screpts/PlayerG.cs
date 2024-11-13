using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerG
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

        if (healthy > 100)
        {
            healthy = 100;
        }

        Debug.Log($"Player {playerName} healed by {amount}. Current health: {healthy}");
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            healthy = 100;
            Debug.Log(healthy);
        }
    }

    public void ReLife()
    {
        int nowHealthy = 0;

        if (healthy > 100)
        {
            Heal(true);
            Debug.Log("The Healthy Back to 100");
        }
        else if (healthy < 0)
        {
            healthy = 0;
            Debug.Log("The Healthy Back to 0");

        }
        else if (healthy >= 0 && healthy < 100)
        {
            while (healthy < 100)
            {
                healthy++;
                nowHealthy++;
            }
            Debug.Log("Healthy added your life again");
            Debug.Log(nowHealthy);
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"Total Players: {playerCount}");
    }
}
