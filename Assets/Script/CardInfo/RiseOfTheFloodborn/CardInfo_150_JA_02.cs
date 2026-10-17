using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_02 : CardInfo
{
    public CardInfo_150_JA_02()
    {
        this.cardNo = "150_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ジェームズ";
        this.cardName2 = "理想の父親";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Kevin Hong";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = true; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
