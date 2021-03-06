using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CustomGameMenu : MonoBehaviour
{
    [SerializeField] private MapSelector mapSelectionMenu;
    [Space(10)]

    [SerializeField] private TMP_InputField playersOnTeam1;
    [SerializeField] private TMP_InputField playersOnTeam2;
    [Space(10)]

    [SerializeField] private Toggle useDynamicDifficultyTeam1;
    [SerializeField] private Toggle useDynamicDifficultyTeam2;
    [Space(10)]

    [SerializeField] private TMP_InputField difficultyTeam1;
    [SerializeField] private TMP_InputField difficultyTeam2;
    [Space(10)]

    [SerializeField] private TextMeshProUGUI timeLimit;
    [Space(10)]

    [SerializeField] private TMP_InputField scoreLimitTeam1;
    [SerializeField] private TMP_InputField scoreLimitTeam2;

    public void StartGame()
    {
        // TODO: Simplify this!

        int valueInt;
        if (int.TryParse(playersOnTeam1.text, out valueInt)) PlayerPrefs.SetInt("Players Team1", valueInt);
        if (int.TryParse(playersOnTeam2.text, out valueInt)) PlayerPrefs.SetInt("Players Team2", valueInt);

        PlayerPrefs.SetInt("Use Dynamic Difficulty Team1", useDynamicDifficultyTeam1.isOn ? 1 : 0);
        PlayerPrefs.SetInt("Use Dynamic Difficulty Team2", useDynamicDifficultyTeam2.isOn ? 1 : 0);

        float valueFloat;
        if (float.TryParse(difficultyTeam1.text, out valueFloat)) PlayerPrefs.SetFloat("Difficulty Team1", valueFloat);
        if (float.TryParse(difficultyTeam2.text, out valueFloat)) PlayerPrefs.SetFloat("Difficulty Team2", valueFloat);

        if (float.TryParse(timeLimit.text, out valueFloat)) PlayerPrefs.SetFloat("Time Limit", valueFloat);

        if (float.TryParse(scoreLimitTeam1.text, out valueFloat)) PlayerPrefs.SetFloat("Score Limit Team1", valueFloat);
        if (float.TryParse(scoreLimitTeam2.text, out valueFloat)) PlayerPrefs.SetFloat("Score Limit Team2", valueFloat);

        SceneManager.LoadScene(mapSelectionMenu.selectedMap);
    }
}
