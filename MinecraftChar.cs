using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MinecraftChar : MonoBehaviour
{
    CreatePolygon cp;
    public Part part;
    public Vector3 pos;
    public float w, h, d;
    
    private void Awake()
    {
        cp = new CreatePolygon();

        MeshFilter mf = GetComponent<MeshFilter>(); // 해당 오브젝트 컴포넌트에 있는 매쉬필터를 가져옴

        Mesh m = new Mesh(); // 매쉬 초기화

        m = cp.CreatCube(part, pos ,w,h,d);

        mf.mesh = m;
    }
    

}
