using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_01 : CardInfo
{
    public CardInfo_083_JA_01()
    {
        this.cardNo = "083_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジャンバ博士";
        this.cardName2 = "反逆的科学者";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Milica Celikovic";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Alien, EnumController.Class.Inventor};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
