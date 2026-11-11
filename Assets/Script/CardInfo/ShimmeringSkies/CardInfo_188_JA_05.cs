using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_05 : CardInfo
{
    public CardInfo_188_JA_05()
    {
        this.cardNo = "188_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "エクター卿";
        this.cardName2 = "城主";
        this.power = 7;
        this.toughness = 10;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
