using UnityEngine;
using UnityEngine.UIElements;

public class TabbedInventoryUI : MonoBehaviour
{
    [SerializeField] RectTransform rtPanel;

    // Start collapsed; flip sign for expand
    private float LeftCoordinateAbsolute = -335.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rtPanel.anchoredPosition3D = new Vector3(LeftCoordinateAbsolute,
            rtPanel.anchoredPosition3D.y,
            rtPanel.anchoredPosition3D.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnExpandButtonClicked()
    {
        float newLeftCoordinate = -1 * rtPanel.anchoredPosition3D.x;
        rtPanel.anchoredPosition3D = new Vector3(newLeftCoordinate,
            rtPanel.anchoredPosition3D.y,
            rtPanel.anchoredPosition3D.z);
    }
}
