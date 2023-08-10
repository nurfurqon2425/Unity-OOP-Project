using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI counterText;

    public static Counter Instance;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = "Counter: " + count;
    }
}
