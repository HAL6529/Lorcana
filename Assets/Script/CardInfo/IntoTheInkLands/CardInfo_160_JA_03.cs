using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_03 : CardInfo
{
    public CardInfo_160_JA_03()
    {
        this.cardNo = "160_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "Friend Like Me";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Emily Abeydeera";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = true; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
