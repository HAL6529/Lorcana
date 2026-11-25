using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_13 : CardInfo
{
    public CardInfo_190_JA_13()
    {
        this.cardNo = "190_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イラ立ったシェフ";
        this.cardName2 = "ムドカの店の料理人";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
