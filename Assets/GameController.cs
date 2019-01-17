using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public int[,] grid = new int[5, 5];//格子
    public int a;//格子橫坐標
    public int b;//格子縱座標
    public int around = 0;//偵測周圍九宮格的地雷數
    public bool bomb;//偵測現在所在格是否有炸彈
    public string bombcount;//剩餘地雷數
    public Sprite[] icons;//周圍地雷數字的圖
    public Sprite[] skeleton;//失敗的骷髏
    public Sprite[] nothing;//空白的格子
    public GameObject boxprefab;
    // Use this for initialization
    void Start()
    {
        /*
        for (int i = 0; i < 7; i++)
        {
            float x;
            x = i * 45.6f;
            Instantiate(boxprefab, new Vector3(-134f+x, -164, 0), Quaternion.identity);
        }//88.4 -134
        */
        int landminex = Random.Range(0, 7);
        int landminey = Random.Range(0, 8);
        if (grid[landminex, landminey] != 1)
        {
            for (int i = 0; i < 8; i++)
            {
                grid[landminex, landminey] = 1;
            }
        }

        //grid[0, 0] = 1;

    }

    // Update is called once per frame
    void Update()
    {

        /*
        [0,1]
        [0,2]
        [0,3]
        [0,4]
        [1,0]
        [1,1]
        [1,2]
        [1,3]
        [1,4]
        [2,0]
        [2,1]
        [2,2]
        [2,3]
        [2,4]
        [3,0]
        [3,1]
        [3,2]
        [3,3]
        [3,4]
        [4,0]
        [4,1]
        [4,2]
        [4,3]
        [4,4];
        */
    }
    public int CheckAround(int[,] grid, int x, int y)
    {
        if (x > 0 && y > 0)
        {
            int around = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int c = x - 1 + i;
                    int d = y - 1 + j;
                    if (x == x && y == y)
                    {
                        continue;
                    }
                    else if (grid[c, d] == 1)
                    {
                        around = around + 1;
                    }
                }
            }
        }
        else { }
        return around;
        /*
        if (grid[a - 1, b + 1]=1)
        {
        }
        grid[a-1, b]
        grid[a-1, b-1]
        grid[a, b+1]
        grid[a, b-1]
        grid[a+1, b+1]
        grid[a+1, b]
        grid[a+1, b-1]
                */
    }
    void ChangePic()
    {
        //不曉得該繼續用around還是用別的變數代表，總之是地雷數
        /*
        if (around = 1)//一顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 2)//兩顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 3)//三顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 4)//四顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 5)//五顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 6)//六顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 7)//七顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        else if (around = 8)//八顆地雷
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()icons[];
        }
        */
    }
    private void OnMouseDown()
    {
        //if (grid[a, b] == 1)
        {
            //bomb = true;//某bool=true
            //爆掉→換骷髏頭→放大→gameover
            //GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()skeleton[];
        }
        //else//沒地雷的情況
        {
            //if (around > 0)//是數字
            {
                //ChangePic();//換數字的圖片
            }
            //else
            {
                //換空白的圖片
                //GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()nothing[];
            }
        }
    }
}
//下面是除雷(不知道是不是這個script)
//宣告
//public bool placeflag;
//public Sprite[] flag;
//public void PickOutBomb()
//{
    //偵測到空白鍵→collider
    //換旗子圖片
    //GetComponent<SpriteRenderer>().sprite = core.GetComponent<>()flag[];

    //當第一次按空白鍵→變數int spacenum = 1;
    //傳變數bool placeflag = true;
    //→bombcount = bombcount - 1;

    //當再按一次空白鍵→變數int spacenum = 0;
    //當bool removeflag = true;(另一個bool?)
    //→bombcount = bombcount + 1;b
//}


