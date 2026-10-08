using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_01 : CardInfo
{
    public CardInfo_178_JA_01()
    {
        this.cardNo = "178_JA_01";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ガントゥ";
        this.cardName2 = "銀河連邦大尉";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Luis Huerta";
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
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
