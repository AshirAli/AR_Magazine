using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointCounter : MonoBehaviour {

    public GameObject PointText, prefab;
    public static int point = 0;
    public int TotalPoints;

    private TextMeshProUGUI textMesh;
	void Update () {

        textMesh = PointText.GetComponent<TextMeshProUGUI>();
        textMesh.text = point.ToString() + " / " + TotalPoints.ToString();
	}
    public void Increment()
    {
        prefab.SetActive(true);
        FindObjectOfType<AudioManager>().Play("CoinCollect");
        Invoke("Stop", 1);
    }

    void Stop()
    {
        prefab.SetActive(false);
        PointCounter.point += 1;
    }

}
