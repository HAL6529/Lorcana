using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_02 : CardInfo
{
    public CardInfo_075_JA_02()
    {
        this.cardNo = "075_JA_02";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "チェシャ猫";
        this.cardName2 = "影からニヤニヤ";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Jeff Murchie";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
