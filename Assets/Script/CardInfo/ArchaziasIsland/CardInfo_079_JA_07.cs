using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_07 : CardInfo
{
    public CardInfo_079_JA_07()
    {
        this.cardNo = "079_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ƒ€ƒtƒ@ƒT";
        this.cardName2 = "‹ó‚Ì‰¤";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
