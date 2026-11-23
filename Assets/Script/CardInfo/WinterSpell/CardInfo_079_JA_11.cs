using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_11 : CardInfo
{
    public CardInfo_079_JA_11()
    {
        this.cardNo = "079_JA_11";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ステグマット";
        this.cardName2 = "おっちょこちょいな恐竜";
        this.power = 7;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DavidGalopim;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Dinosaur };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
