using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // ENCAPSULATION
    public static GameManager Instance { get; private set; }

    [SerializeField]
    private TextMeshProUGUI nameText;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void DisplayName(string animalName)
    {
        nameText.text = animalName;
    }
}
