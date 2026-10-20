using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_03 : CardInfo
{
    public CardInfo_106_JA_03()
    {
        this.cardNo = "106_JA_03";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "デラ・ダック";
        this.cardName2 = "無敵のママ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = "Rudy / Hill";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
