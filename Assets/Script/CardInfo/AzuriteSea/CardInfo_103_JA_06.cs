using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_06 : CardInfo
{
    public CardInfo_103_JA_06()
    {
        this.cardNo = "103_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "海賊船長";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
