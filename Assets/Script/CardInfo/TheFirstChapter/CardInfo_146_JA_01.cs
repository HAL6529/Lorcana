using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_01 : CardInfo
{
    public CardInfo_146_JA_01()
    {
        this.cardNo = "146_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒ^ƒ‰‚¨‚Î‚ ‚¿‚á‚ñ";
        this.cardName2 = "Œê‚è•”";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = "Filipe Laurentino";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
