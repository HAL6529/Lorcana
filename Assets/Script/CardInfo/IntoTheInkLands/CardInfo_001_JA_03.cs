using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_03 : CardInfo
{
    public CardInfo_001_JA_03()
    {
        this.cardNo = "001_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "バルー";
        this.cardName2 = "フォン・ブルーインヴァルト13世";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Cam Kendell";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = true; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = true; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
