using UnityEngine;
using UnityEngine.UI;

public class MedalInfoUI : MonoBehaviour
{
    [SerializeField] private Image[] medalImages;
    [SerializeField] private Bag bag;

    private int countPieces;

    private void Start()
    {
        if (bag != null)
        {
            bag.ChangeMedalPieceAmount.AddListener(SetImageVisible);
        }
        SetImageInvisible();
    }

    private void OnDestroy()
    {
        if (bag != null)
        {
            bag.ChangeMedalPieceAmount.RemoveListener(SetImageVisible);
        }
    }

    private void SetImageVisible()
    {
        if (countPieces >= medalImages.Length)
        {
            SetImageInvisible();
            countPieces = 0;
            medalImages[countPieces].color = Color.white;
        }
        else
        {
            medalImages[countPieces].color = Color.white;
        }

        countPieces++;
    }

    private void SetImageInvisible()
    {
        for (int i = 0; i < medalImages.Length; i++)
        {
            medalImages[i].color = new Color(1, 1, 1, 0.4f);
        }
    }
}