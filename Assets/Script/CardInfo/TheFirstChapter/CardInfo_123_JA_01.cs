using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_01 : CardInfo
{
    public CardInfo_123_JA_01()
    {
        this.cardNo = "123_JA_01";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "スカー";
        this.cardName2 = "恥知らずな煽り屋";
        this.power = 6;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = "Jenna Gray";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = true; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
