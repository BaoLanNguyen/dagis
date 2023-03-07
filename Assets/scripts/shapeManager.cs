using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class shapeManager : MonoBehaviour
{
    [SerializeField] private List<shapeSlot> _slotPrefabs;
    [SerializeField] private shape _shapePrefab;
    [SerializeField] private Transform _slotParent, _shapeParent;

    void Start() {
        Spawn();
    }
    void Spawn(){
        var randomSet = _slotPrefabs.OrderBy(s=>Random.value).Take(4).ToList();

        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedSlot = Instantiate(randomSet[i], _slotParent.GetChild(i).position, Quaternion.identity);

            var spawnedShape = Instantiate(_shapePrefab, _shapeParent.GetChild(i).position, Quaternion.identity);
            spawnedShape.Init(spawnedSlot);
        }
    }
}
