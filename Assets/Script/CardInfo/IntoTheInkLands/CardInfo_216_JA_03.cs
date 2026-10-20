using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_216_JA_03 : CardInfo
{
    public CardInfo_216_JA_03()
    {
        this.cardNo = "216_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "RLSレガシー号";
        this.cardName2 = "ソーラーガレオン";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = "Wietse Treurniet";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = true; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Enchanted;
    }
}
