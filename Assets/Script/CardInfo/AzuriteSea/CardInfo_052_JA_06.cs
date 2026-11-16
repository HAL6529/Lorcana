using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_06 : CardInfo
{
    public CardInfo_052_JA_06()
    {
        this.cardNo = "052_JA_06";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ƒ‰ƒtƒBƒL";
        this.cardName2 = "—ì–­‚Ì“±‚«Žè";
        this.power = 6;
        this.toughness = 6;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.SamNielson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift7 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
