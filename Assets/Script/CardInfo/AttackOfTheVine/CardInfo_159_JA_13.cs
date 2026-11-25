using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_13 : CardInfo
{
    public CardInfo_159_JA_13()
    {
        this.cardNo = "159_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
