using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UserManager : MonoBehaviour
{
    public static UserManager Instance { get; private set; }

    public string Name { get; set; } = "John Doe";
    public HighScore HighScore { get; private set; }

    private string SavePath => $"{Application.persistentDataPath}/user.json";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveHighScore(HighScore highScore)
    {
        HighScore = highScore;
        var json = JsonUtility.ToJson(HighScore);
        File.WriteAllText(SavePath, json);
    }

    public void LoadHighScore()
    {
        if (File.Exists(SavePath))
        {
            var json = File.ReadAllText(SavePath);
            HighScore = JsonUtility.FromJson<HighScore>(json);
        }
    }
}
