using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameStateController : MonoBehaviour
{
    private static GameStateController instance;
    public static GameStateController Instance
    {
        get
        {
            if (!instance)
            {
                GameStateController[] gameStateControllers = FindObjectsOfType<GameStateController>();
                if(gameStateControllers.Length > 1)
                {
                    string controllerParentObjects = gameStateControllers[0].name;
                    for(int i = 1; i < gameStateControllers.Length; i++)
                    {
                        controllerParentObjects = string.Format("{0}, {1}", controllerParentObjects, gameStateControllers[i].name);
                    }
                    throw new UnityException(string.Format("{0} all have GameStateController in the scene! Must have just one.", controllerParentObjects));
                }
                instance = gameStateControllers[0];
            }
            return instance;
        }
    }

    private void Awake()
    {
        CoinController.CollectedCoinEvent += CollectedCoin;
    }

    private void OnDisable()
    {
        CoinController.CollectedCoinEvent -= CollectedCoin;
    }

    private void CollectedCoin()
    {
        Debug.Log("I did it!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
