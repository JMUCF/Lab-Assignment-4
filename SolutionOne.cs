using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionOne : MonoBehaviour
{
    //INPUT VARIABLES
    private string characterName = "Pikachu";
    private int characterLevel = 10;
    private string className = "Paladin";
    private int conScore = 18;
    private bool isHillDwarf = false; 
    private bool hasToughFeat = true;
    private bool isAveraged = false; //true is average false is rolled

    // ADDITIONAL VARIABLES / STRUCTURES
    Dictionary<string, int> classes = new Dictionary<string, int>
    {
        {"Artificer", 8},
        {"Barbarian", 12},
        {"Bard", 8},
        {"Cleric", 8},
        {"Druid", 8},
        {"Fighter", 10},
        {"Monk", 8},
        {"Ranger", 10},
        {"Rogue", 8},
        {"Paladin", 10},
        {"Sorcerer", 6},
        {"Wizard", 6},
        {"Warlock", 8}
    };

    Dictionary<int, int> conMods = new Dictionary<int, int>
    {
        {1, -5},
        {2, -4},
        {3, -4},
        {4, -3},
        {5, -3},
        {6, -2},
        {7, -2},
        {8, -1},
        {9, -1},
        {10, 0},
        {11, 0},
        {12, 1},
        {13, 1},
        {14, 2},
        {15, 2},
        {16, 3},
        {17, 3},
        {18, 4},
        {19, 4},
        {20, 5},
        {21, 5},
        {22, 6},
        {23, 6},
        {24, 7},
        {25, 7},
        {26, 8},
        {27, 8},
        {28, 9},
        {19, 9},
        {30, 10}
    };

    private int hitDie;
    private int totalHealth;
    void Start()
    {
        Debug.Log(FindHitdie(className));
    }

    private int FindHitdie(string className)
    {
        if(classes.ContainsKey(className))
            return(10);
        else
            return 0;
    }
}