using UnityEngine;

public class PlayerController : MonoBehaviour, ICustomer 
{

    [SerializeField]
    private int reputation = 0;

    public int Reputation{ get; private set; }

    private void Awake()
    {
        Reputation = reputation;
    }

    public void Trading(string message)
    {
        Debug.Log("Начинаем торговлю" + message);
    }
}
