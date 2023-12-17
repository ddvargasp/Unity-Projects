using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Level
{
    [Range(1, 11)] // Rango de plataformas
    public int partCount = 11; // Cantidad de plataformas

    [Range(0, 11)]
    public int deathPartCount = 11;
}

[CreateAssetMenu(fileName = "New Stage")] // Se crea el elemento Stage como un asset
public class Stage : ScriptableObject
{
    public Color stageBackgroundColor = Color.white;
    public Color stageLevelPartColor = Color.white;
    public Color stageBallColor = Color.white;

    public List<Level> levels  = new List<Level>();
}
