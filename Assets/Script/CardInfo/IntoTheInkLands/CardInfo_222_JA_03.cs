using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_03 : CardInfo
{
    public CardInfo_222_JA_03()
    {
        this.cardNo = "222_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "そこに登場、ゼウス！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Isabella Ceravolo";
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
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Enchanted;
    }
}
