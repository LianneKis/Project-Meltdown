using UnityEngine;

public class Firearms : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
	
	// Update is called once per frame
	void Update () {

		
	}

    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range));
        {
            Debug.Log(hit.transform.name);
        }
    }
}
