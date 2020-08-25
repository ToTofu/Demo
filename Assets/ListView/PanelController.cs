﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    [SerializeField] ListView m_listView;
    [SerializeField] GameObject m_goodsItemPrefab;
    [SerializeField] Button m_shenbingButton;
    [SerializeField] Button m_daojuButton;

    List<GoodsData> m_shenbingDataList;
    List<GoodsData> m_daojuDataList;

    bool isShowShenbingList;
    
    void Start()
    {
        m_shenbingDataList = new List<GoodsData>
        {
            new GoodsData("蔷薇剑", 2000),
            new GoodsData("木叶飞刀", 3000),
            new GoodsData("百晓生", 5000),
            new GoodsData("孔雀翎", 10000),
            new GoodsData("大悲赋", 12000),
        };
        
        m_daojuDataList = new List<GoodsData>
        {
            new GoodsData("皇凤血", 2000),
            new GoodsData("陨焰之石", 3000),
            new GoodsData("缘材进", 5000),
            new GoodsData("灵玉", 10000),
            new GoodsData("道具1", 12000),
            new GoodsData("道具2", 12000),
            new GoodsData("道具3", 12000),
            new GoodsData("道具4", 12000),
            new GoodsData("道具5", 12000),
            new GoodsData("道具6", 12000),
            new GoodsData("道具7", 12000),
            new GoodsData("道具8", 12000),
            new GoodsData("道具9", 12000),
            new GoodsData("道具10", 12000),
            new GoodsData("道具11", 12000),
            new GoodsData("道具12", 12000),
            new GoodsData("道具13", 12000),
            new GoodsData("道具14", 12000),
            new GoodsData("道具15", 12000),
            new GoodsData("道具16", 12000),
            new GoodsData("道具17", 12000),
            new GoodsData("道具18", 12000),
            new GoodsData("道具19", 12000),
            new GoodsData("道具20", 12000),
            new GoodsData("道具21", 12000),
            new GoodsData("道具22", 12000),
            new GoodsData("道具23", 12000),
            new GoodsData("道具24", 12000),
        };
        
        m_shenbingButton.onClick.AddListener(OnShenbingClicked);
        m_daojuButton.onClick.AddListener(OnDaojuClicked);

        isShowShenbingList = true;
        m_listView.Init(m_goodsItemPrefab, m_shenbingDataList.Count, OnItemRefresh);
    }

    void OnShenbingClicked()
    {
        isShowShenbingList = true;
        m_listView.itemCount = m_shenbingDataList.Count;
    }

    void OnDaojuClicked()
    {
        isShowShenbingList = false;
        m_listView.itemCount = m_daojuDataList.Count;
    }
    
    void OnItemRefresh(int index, ListViewItem item)
    {
        GoodsItem goodsItem = item as GoodsItem;
        goodsItem.Init(isShowShenbingList ? m_shenbingDataList[index] : m_daojuDataList[index]);
    }
}
