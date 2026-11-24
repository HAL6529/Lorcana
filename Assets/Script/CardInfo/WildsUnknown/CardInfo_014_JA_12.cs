using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_12 : CardInfo
{
    public CardInfo_014_JA_12()
    {
        this.cardNo = "014_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "チップ";
        this.cardName2 = "救出専門家";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RodrigoRaposo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
