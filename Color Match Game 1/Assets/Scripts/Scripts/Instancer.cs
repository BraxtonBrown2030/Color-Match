using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
   public GameObject prefab;
   private int num;
   
   public void CreatInstance()
   {

      Instantiate(prefab);

   }

   public void CreateInstance(Vector3Data obj)
   {

      Instantiate(prefab, obj.value, Quaternion.identity);

   }

   public void CreateIncstanceFromList(Vector3DataList obj)
   {
      foreach (var t in obj.vector3List)
      {
         Instantiate(prefab, t.value, Quaternion.identity);
      }
   }
   
   public void CreateIncstanceFromListCounting(Vector3DataList obj)
   {
      Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
      num++;
      if (num == obj.vector3List.Count)
      {
         num = 0;
      }
   }
   public void CreateIncstanceFromListRandomly(Vector3DataList obj)
   {
      num = Random.Range(0, obj.vector3List.Count - 1);
      Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
      
   }
}