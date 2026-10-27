using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_03 : CardInfo
{
    public CardInfo_178_JA_03()
    {
        this.cardNo = "178_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "リトル・ジョン";
        this.cardName2 = "とんちに長けた無法者";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Filipe Laurentino";
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
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
