using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_01 : CardInfo
{
    public CardInfo_147_JA_01()
    {
        this.cardNo = "147_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "冥府の策謀家";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Matthew Robert Davies";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = true; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = true; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
