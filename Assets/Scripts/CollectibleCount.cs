using System.Threading;
using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    public int count;
    public int total;
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Update()
    {
        text.text = $"Coins Collected: {count} / {total}";
    }
}
