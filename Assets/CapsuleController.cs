using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{

   
    [SerializeField] private GameObject redCapsule;
    [SerializeField] private GameObject blueCapsule;
    [SerializeField] private GameObject greenCapsule;
    [SerializeField] private GameObject yellowCapsule;
    [SerializeField] private float spawnTime;

    private int random;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCapsuleTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    private IEnumerator SpawnCapsuleTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        CapsuleSpawner();
        yield return null;
    }

    private void CapsuleSpawner()
    {
        random = Random.Range(1,4);
        
        if (random == 1)
        {
            Instantiate(redCapsule, transform.position, Quaternion.identity);
        } 
        else if (random == 2)
        {
            Instantiate(blueCapsule, transform.position, Quaternion.identity);
        }
        else if (random == 3)
        {
            Instantiate(greenCapsule, transform.position, Quaternion.identity);
        }
        else if (random == 4)
        {
            Instantiate(yellowCapsule, transform.position, Quaternion.identity);
        }

        StartCoroutine(SpawnCapsuleTimer());
    }
}
