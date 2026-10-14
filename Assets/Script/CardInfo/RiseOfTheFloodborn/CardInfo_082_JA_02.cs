using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_02 : CardInfo
{
    public CardInfo_082_JA_02()
    {
        this.cardNo = "082_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "オレの最大のファンであるオレ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 4;
        this.illustrator = "E. Meleranci / L. Giammichele";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
