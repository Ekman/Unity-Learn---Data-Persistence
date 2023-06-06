using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public TMP_InputField nameField;

    public void StartGame()
    {
        UserManager.Instance.Name = nameField.text;
        SceneManager.LoadScene(1);
    }
}
