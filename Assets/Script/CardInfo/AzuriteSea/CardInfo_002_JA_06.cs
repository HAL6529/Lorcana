using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_06 : CardInfo
{
    public CardInfo_002_JA_06()
    {
        this.cardNo = "002_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉäÉç";
        this.cardName2 = "î≤ÇØèoÇµñºêl";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GrzegorzKrysinski;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
