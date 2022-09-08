using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueStackList : MonoBehaviour
{
    //Queue, Stack, List
    public GameObject one_gameobject;
    public Queue<GameObject> queue_gameobject;
    public Stack<GameObject> stack_gameobject;
    public List<GameObject> list_gameobject;
    public void Start(){
        queue_gameobject.Enqueue(new GameObject()); //끝 부분에 추가(큐에 추가됨)
        GameObject one_gameobject = queue_gameobject.Dequeue(); //시작 부분에서 반환(큐에서 제거됨)
        GameObject one_gameobject = queue_gameobject.Peek(); //시작 부분에서 반환(큐에 유지)

        stack_gameobject.Push(new GameObject()); //시작 부분에 추가(스택에 추가됨)
        GameObject one_gameobject = stack_gameobject.Pop(); //시작 부분에서 반환(큐에서 제거됨)
        GameObject one_gameobject = stack_gameobject.Peek(); //시작 부분에서 반환(큐에 유지)

        list_gameobject.Add(new GameObject());
        list_gameobject.Insert(1, new GameObject());
        list_gameobject.Remove("gameObject");
        list_gameobject.RemoveAt(1);
    }
}