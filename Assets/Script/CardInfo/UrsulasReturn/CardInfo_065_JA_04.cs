using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_04 : CardInfo
{
    public CardInfo_065_JA_04()
    {
        this.cardNo = "065_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "薔薇のランタン";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Gabriel Angelo";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}
