using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_06 : CardInfo
{
    public CardInfo_054_JA_06()
    {
        this.cardNo = "054_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "シスー";
        this.cardName2 = "心つなぐ龍";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ShannonHallstein;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
