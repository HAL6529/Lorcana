using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_06 : CardInfo
{
    public CardInfo_037_JA_06()
    {
        this.cardNo = "037_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "+";
        this.cardName2 = "è¨Ç≥Ç≠Ç‡Ç»ÇÍÇÈñÇèó";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MoniekSchilder;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger1 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
