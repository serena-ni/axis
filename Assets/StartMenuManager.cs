using UnityEngine;

public class StartMenuManager : MonoBehaviour
{
    public GameObject infoPanel;

    public void OpenInfo()
    {
        infoPanel.SetActive(true);
    }

    public void CloseInfo()
    {
        infoPanel.SetActive(false);
    }
}
