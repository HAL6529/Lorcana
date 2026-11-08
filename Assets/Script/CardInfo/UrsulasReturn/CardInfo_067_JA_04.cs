using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_04 : CardInfo
{
    public CardInfo_067_JA_04()
    {
        this.cardNo = "067_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マドリガル家のおうち";
        this.cardName2 = "カシータ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = "Rachel Elese";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = true; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
