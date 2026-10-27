using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_03 : CardInfo
{
    public CardInfo_004_JA_03()
    {
        this.cardNo = "004_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ダルメシアンの子犬";
        this.cardName2 = "しっぽフリフリちゃん";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Kapik";
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
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
