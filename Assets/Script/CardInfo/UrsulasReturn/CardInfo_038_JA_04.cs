using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_04 : CardInfo
{
    public CardInfo_038_JA_04()
    {
        this.cardNo = "038_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ブルーノ・マドリガル";
        this.cardName2 = "影から出てきた男";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
