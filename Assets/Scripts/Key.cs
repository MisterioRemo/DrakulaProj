using UnityEngine;

public enum Name
{
    Key,
}

public class Key : Pikup
{
    [SerializeField] private Name lootName;
    [SerializeField] private int keyCount;
    
    [SerializeField] private GameObject impactEffect;
    
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Bag bag = other.GetComponent<Bag>();

        if (bag)
        {
            bag.AddKey(keyCount);

            if (impactEffect)
                Instantiate(impactEffect, transform.position, Quaternion.identity);
        }
    }
}