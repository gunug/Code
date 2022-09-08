using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonClass : MonoBehaviour
{
    
    //싱글톤 패턴
    public static SingletonClass instance;
    //static 정적인 , dynamic 동적인
    //dynamic : instance = new SingletonClass(); 동적생성
    //static : SingletonClass.instance

    public Awake(){
        init();
    }
    
    public SingletonClass init(){
        if(instance == null){
            instance = new SingletonClass();
        }
        return instance;
    }
}