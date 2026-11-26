using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_14 : CardInfo
{
    public CardInfo_144_JA_14()
    {
        this.cardNo = "144_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ハニー・レモン";
        this.cardName2 = "独創的な研究者";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FahedAlrajil;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
