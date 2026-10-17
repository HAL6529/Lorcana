using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_02 : CardInfo
{
    public CardInfo_199_JA_02()
    {
        this.cardNo = "199_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "風よ吹け";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "R. la Barbera / L. Giammichele";
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
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}
