using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_07 : CardInfo
{
    public CardInfo_072_JA_07()
    {
        this.cardNo = "072_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒAƒi";
        this.cardName2 = "•X‚ð‚­‚¾‚«‚µŽÒ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
