using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_13 : CardInfo
{
    public CardInfo_182_JA_13()
    {
        this.cardNo = "182_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マタ";
        this.cardName2 = "ムドカの店のウェイトレス";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CelesteJamneck;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
