using UnityEngine;

public class bulletscript : MonoBehaviour
{
    [SerializeField]
    private float currentime;
    [SerializeField]
    private float maxtime;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            currentime += Time.deltaTime;
            if (currentime > maxtime)
            {
                gameObject.SetActive(false);
                currentime = 0;
            }
        }
    }
}
