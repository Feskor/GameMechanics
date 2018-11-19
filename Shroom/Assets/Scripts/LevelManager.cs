using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    [SerializeField]private GameObject _playerObject;
    public PlayerMovement PlayerMovement { get; private set; }

    public static LevelManager Instance;

    public Vector2 lastCheckpoint;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            if (Instance != this)
                Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start ()
    {
        PlayerMovement = _playerObject.GetComponent<PlayerMovement>();
        
      
        
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void Respawn()
    {
        PlayerMovement.transform.position = lastCheckpoint;
    }
}
