using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_07 : CardInfo
{
    public CardInfo_069_JA_07()
    {
        this.cardNo = "069_JA_07";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ƒGƒ‹ƒT";
        this.cardName2 = "•X‚ð‚Â‚­‚è‚µŽÒ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
