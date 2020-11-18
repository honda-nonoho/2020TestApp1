using System;
using UnityEngine;
using UnityEngine.UI;

// key 親
[Serializable] public class TestJsonParent
{
    public TestJsonChild[] data;
}

// key 子
    [Serializable] public class TestJsonChild
    {
        public int id;
        public string title;
        public string subTitle;
        public string mainImage;
        public string explanationText;

        public string imageText;

    }
