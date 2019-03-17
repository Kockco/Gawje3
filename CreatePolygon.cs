using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Part
{
    Head= 0, Hat, RLeg, Body, RArm, RLeg2, Jaket, RArm2, LLeg2, LLeg, LArm, LArm2
}

public class CreatePolygon : MonoBehaviour{
    Mesh m = new Mesh();
    void CreatePg(Vector3 v1, Vector3 v2 , Vector3 v3, Vector3 v4, 
        Vector3 v5, Vector3 v6, Vector3 v7, Vector3 v8)
    {
        m.vertices = new Vector3[]
        {
            //front 
                new Vector3(v1.x,v1.y,v1.z),
                new Vector3(v1.x,v2.y,v1.z),
                new Vector3(v2.x,v2.y,v2.z),
                new Vector3(v2.x,v1.y,v2.z),
                //left
                new Vector3(v3.x,v3.y,v3.z),
                new Vector3(v3.x,v4.y,v3.z),
                new Vector3(v4.x,v4.y,v4.z),
                new Vector3(v4.x,v3.y,v4.z),
                //behind
                new Vector3(v5.x,v5.y,v5.z),
                new Vector3(v5.x,v6.y,v5.z),
                new Vector3(v6.x,v6.y,v6.z),
                new Vector3(v6.x,v5.y,v6.z),
                //right
                new Vector3(v7.x,v7.y,v7.z),
                new Vector3(v7.x,v8.y,v7.z),
                new Vector3(v8.x,v8.y,v8.z),
                new Vector3(v8.x,v7.y,v8.z),
                //up
                new Vector3(v4.x,v4.y,v4.z),
                new Vector3(v4.x,v8.y,v8.z),
                new Vector3(v8.x,v8.y,v8.z),
                new Vector3(v8.x,v4.y,v4.z),
                //down
                new Vector3(v3.x,v3.y,v3.z),
                new Vector3(v3.x,v7.y,v7.z),
                new Vector3(v7.x,v7.y,v7.z),
                new Vector3(v7.x,v3.y,v3.z),
        };
        m.triangles = new int[]
        {
            0, 1, 2,
            2, 3, 0
            ,
            4, 5, 6,
            4, 6, 7
            ,
            8, 9, 10,
            8, 10 ,11
            ,
            12, 13, 14,
            12, 14, 15
            ,
            16, 17, 18,
            16, 18, 19
            ,
            20, 21, 22,
            20, 22, 23
        };
    
        

    }
    void CreateUv(Vector2 v1, Vector2 v2, Vector2 v3, Vector2 v4, 
        Vector2 v5, Vector2 v6, Vector2 v7, Vector2 v8, Vector2 v9, Vector2 v10, Vector2 v11, Vector2 v12)
    {
        m.uv = new Vector2[] // Texture
        {
            //front
            v1,
            new Vector2(v1.x, v2.y),
            v2,
            new Vector2(v2.x, v1.y),
            //left
             v3,
            new Vector2(v3.x, v4.y),
            v4,
            new Vector2(v4.x, v3.y),
            //back
             v5,
            new Vector2(v5.x, v6.y),
            v6,
            new Vector2(v6.x, v5.y),
            //right
             v7,
            new Vector2(v7.x, v8.y),
            v8,
            new Vector2(v8.x, v7.y),
            //up
             v9,
            new Vector2(v9.x, v10.y),
            v10,
            new Vector2(v10.x, v9.y),
            //down
             v11,
            new Vector2(v11.x, v12.y),
            v12,
            new Vector2(v12.x, v11.y),
        };
    }

    public Mesh CreatCube(Part part, Vector3 pos,float w,float h, float d)
    {
        CreatePg(new Vector3(-w, -h, -d) + pos, new Vector3(w, h, -d) + pos, new Vector3(-w, -h, d) + pos, new Vector3(-w, h, -d) + pos,
                    new Vector3(w, -h, d) + pos, new Vector3(-w, h, d) + pos, new Vector3(w, -h, -d) + pos, new Vector3(w, h, d) + pos);
        switch (part)
        {
            case Part.Head:
                CreateUv(new Vector2(0.125f, 0.75f), new Vector2(0.25f, 0.875f), new Vector2(0.375f, 0.75f), new Vector2(0.25f, 0.875f),
                    new Vector2(0.375f, 0.75f), new Vector2(0.5f, 0.875f), new Vector2(0.125f, 0.75f), new Vector2(0, 0.875f),
                    new Vector2(0.125f, 0.875f), new Vector2(0.25f, 1.0f), new Vector2(0.25f, 0.875f), new Vector2(0.375f, 1.0f));
                break;
            case Part.Hat:
                CreateUv(new Vector2(0.625f, 0.75f), new Vector2(0.75f, 0.875f), new Vector2(0.75f, 0.75f), new Vector2(0.875f, 0.875f),
                    new Vector2(0.875f, 0.75f), new Vector2(1.0f, 0.875f), new Vector2(0.5f, 0.75f), new Vector2(0.625f, 0.875f),
                    new Vector2(0.625f, 0.875f), new Vector2(0.75f, 1.0f), new Vector2(0.75f, 0.875f), new Vector2(0.875f, 1.0f));
                break;
            case Part.RLeg:
                CreateUv(new Vector2(0.0625f, 0.5f), new Vector2(0.125f, 0.6875f), new Vector2(0.125f, 0.5f), new Vector2(01875f, 0.6875f),
                    new Vector2(0.1875f, 0.5f), new Vector2(0.25f, 0.6875f), new Vector2(0f, 0.5f), new Vector2(0.0625f, 0.6875f),
                    new Vector2(0.0625f, 0.6875f), new Vector2(0.125f, 0.75f), new Vector2(0.125f, 0.6875f), new Vector2(0.1875f, 0.75f));
                break;
            case Part.Body:
                CreateUv(new Vector2(0.3125f, 0.5f), new Vector2(0.4375f, 0.6875f), new Vector2(0.5625f, 0.5f), new Vector2(0.625f, 0.6875f),
                    new Vector2(0.4375f, 0.5f), new Vector2(0.5625f, 0.6875f), new Vector2(0.25f, 0.5f), new Vector2(0.3125f, 0.6875f),
                    new Vector2(0.3125f, 0.6875f), new Vector2(0.4375f, 0.75f), new Vector2(0.4375f, 0.6875f), new Vector2(0.5625f, 0.75f));
                break;
            case Part.RArm:
                CreateUv(new Vector2(0.6875f, 0.5f), new Vector2(0.75f, 0.6875f), new Vector2(0.75f, 0.5f), new Vector2(0.8125f, 0.6875f),
                    new Vector2(0.8125f, 0.5f), new Vector2(0.875f, 0.6875f), new Vector2(0.625f, 0.5f), new Vector2(0.6875f, 0.6875f),
                    new Vector2(0.6875f, 0.6875f), new Vector2(0.75f, 0.75f), new Vector2(0.75f, 0.6875f), new Vector2(0.8125f, 0.75f));
                break;
            case Part.LLeg:
                CreateUv(new Vector2(0.3125f, 0f), new Vector2(0.375f, 0.1875f), new Vector2(0.375f, 0f), new Vector2(0.4375f, 0.1875f),
                    new Vector2(0.4375f, 0f), new Vector2(0.5f, 0.1875f), new Vector2(0.25f, 0f), new Vector2(0.3125f, 0.1875f),
                    new Vector2(0.3125f, 0.1875f), new Vector2(0.375f, 0.25f), new Vector2(0.375f, 0.1875f), new Vector2(0.4375f, 0.25f));
                break;
            case Part.LArm:
                CreateUv(new Vector2(0.5f, 0f), new Vector2(0.5625f, 0.1875f), new Vector2(0.5625f, 0f), new Vector2(0.625f, 0.1875f),
                    new Vector2(0.625f, 0f), new Vector2(0.6875f, 0.1875f), new Vector2(0.4375f, 0f), new Vector2(0.5f, 0.1875f),
                    new Vector2(0.5625f, 0.1875f), new Vector2(0.625f, 0.25f), new Vector2(0.625f, 0.1875f), new Vector2(0.6875f, 0.25f));
                break;
        }
        return m;
    }
};
