using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_06 : CardInfo
{
    public CardInfo_048_JA_06()
    {
        this.cardNo = "048_JA_06";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "アズライトの妖精女王";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaiaLopez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Queen, EnumController.Class.Fairy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
