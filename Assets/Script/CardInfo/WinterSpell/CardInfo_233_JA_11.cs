using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_233_JA_11 : CardInfo
{
    public CardInfo_233_JA_11()
    {
        this.cardNo = "233_JA_11";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "エルサ";
        this.cardName2 = "氷の工芸家";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulietteOberndorfer;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
